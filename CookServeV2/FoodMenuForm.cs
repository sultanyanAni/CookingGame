using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CookServeV2
{
    public partial class FoodMenuForm : Form
    {
        Foods foods;
        public FoodMenuForm()
        {
            InitializeComponent();
            foods = JsonConvert.DeserializeObject<Foods>(File.ReadAllText("CookServeRecipes.json"));
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            CookingForm form = new CookingForm(foods.GetFood("Pizza"));
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
