using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookServeV2
{
    public class Foods
    {
        public Food[] Food { get; set; }
        public Food GetFood(string name)
        {
            for (int i = 0; i < Food.Length; i++)
            {
                if(Food[i].Name == name)
                {
                    return Food[i];
                }
            }
            return null;
        }
    }

    public class Food
    {
        public string Name { get; set; }
        public Recipe[] Recipes { get; set; }
        public Ingredient GetIng(string name)
        {
            for (int j = 0; j < Recipes.Length; j++)
            {


                for (int i = 0; i < Recipes[j].Ingredients.Length; i++)
                {
                    if (Recipes[j].Ingredients[i].IngredientName == name)
                    {
                        return Recipes[j].Ingredients[i];
                    }
                }
            }
            
            return null;
        }
    }

    public class Recipe
    {
        public string RecipeName { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public Ingredient GetIng(string name)
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                if (Ingredients[i].IngredientName == name)
                {
                    return Ingredients[i];
                }
            }
            return null;
        }
        public string PrintRecipe()
        {
            string output = "";
            for (int i = 0; i < Ingredients.Length; i++)
            {

                output += Ingredients[i].IngredientName + ", ";

            }
            output = output.Remove(output.Length - 2, 2);
            bool nextLine = false;
            for (int i = 1; i < output.Length; i++)
            {
                if (i % 45 == 0)
                {
                    nextLine = true;
                }
                if (nextLine && output[i] == ' ')
                {
                    output = output.Insert(i, "\n");
                    nextLine = false;
                }
            }

            return output;
        }
    }

    public class Ingredient
    {
        public string IngredientName { get; set; }
        public string IngredientKey { get; set; }
        public string IngredientImage { get; set; }
        public int LayerNum { get; set; }
    }

}
