using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookServeV2
{
    class Customer
    {
        Recipe Order;
        string Name;

        public Customer(string Name, Recipe order)
        {
            this.Name = Name;
            Order = order;
        }

        public string GetOrder()
        {
            return $"{Name} wants {Order.PrintRecipe()}";
        }
    }
}
