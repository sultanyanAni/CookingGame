using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookServeV2
{
    public partial class CookingForm : Form
    {
        Food CurrentFood;
        List<FoodKey> foodKeys;
        List<Ingredient> possibleIngredients;
        Customer test;
        Random gen;
        public CookingForm(Food currentFood)
        {
            InitializeComponent();
            CurrentFood = currentFood;
            Init();
            this.KeyPreview = true; 
            
        }
        void Init()
        {
            gen = new Random();
            possibleIngredients = new List<Ingredient>();
            foodKeys = new List<FoodKey>();
            var ing = CurrentFood.Recipes.SelectMany(x => x.Ingredients).OrderBy(x => x.LayerNum).Select(x => x.IngredientName).Distinct().ToList();
            for (int i = 0; i < ing.Count; i++)
            {
                possibleIngredients.Add(CurrentFood.GetIng(ing[i]));
            }
            string[] names = { "John", "Matt", "Gary" };
            test = new Customer(names[gen.Next(3)], CurrentFood.Recipes[gen.Next(CurrentFood.Recipes.Length)]);

         
        }
        FoodKey addNewFoodKey(Keys key, string ingredient, Point location)
        {
            FoodKey keyToCreate;
            keyToCreate = new FoodKey();
            keyToCreate.Init(key, ingredient);
            keyToCreate.Location = location;

            return keyToCreate;
        }
        private void CookingForm_Load(object sender, EventArgs e)
        {
            FoodKey randomKey = addNewFoodKey(Keys.None, "random", new Point(0, 0));
            int x = ClientSize.Width - randomKey.Width;
            int y = 0;
            for (int i = 0; i < possibleIngredients.Count; i++)
            {
                Keys keyIndex = (Keys)Enum.Parse(typeof(Keys), possibleIngredients[i].IngredientKey);
                FoodKey newFoodKey = addNewFoodKey(keyIndex, possibleIngredients[i].IngredientName, new Point(x, y));

                Controls.Add(newFoodKey);
                foodKeys.Add(newFoodKey);
                y += newFoodKey.Height;
            }
            CustomerLabel.Text = test.GetOrder();
        }

        private void CookingForm_KeyDown(object sender, KeyEventArgs e)
        {
            foreach(var ing in possibleIngredients)
            {
                if(e.KeyCode == ing.GetKey())
                {
                    foreach(var key in foodKeys)
                    {
                        if(ing.IngredientKey == key.key)
                        {
                            key.deactivateKey();
                        }
                    }
                }
            }
       
        }
    }
}
