using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookServeV2
{
    public partial class FoodKey : UserControl
    {
        public string key;
        Image deactivatedBackground;
        public FoodKey()
        {
            InitializeComponent();
            deactivatedBackground = Properties.Resources.deactivatedFoodKeyBackground;
        }
        public void Init(Keys key, string ingredient)
        {
            FoodKeyLabel.Text = key.ToString();
            this.key = key.ToString();
            IngredientLabel.Text = ingredient;
        }

        public void deactivateKey()
        {

            KeyImage.BackgroundImage = deactivatedBackground;
            FoodKeyLabel.BackColor = Color.DimGray;

        }

     
    }
}
