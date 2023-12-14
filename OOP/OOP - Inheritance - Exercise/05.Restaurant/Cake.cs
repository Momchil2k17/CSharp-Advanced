using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake:Dessert
    {
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {
           
        }
        private const double CakeGrams = 250;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5M;

    }
}
