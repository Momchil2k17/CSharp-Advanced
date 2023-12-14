using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Dessert:Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Name = name;
            Price = price;
            Grams = grams;
            Calories = calories;
        }
    }
}
