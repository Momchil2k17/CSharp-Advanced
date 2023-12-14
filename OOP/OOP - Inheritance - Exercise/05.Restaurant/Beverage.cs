using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Beverage:Product
    {
        public double Milliliters  { get; set; }
        public Beverage(string name, decimal price,double milliliters):base(name,price)
        {
            Name = name;
            Price = price;
            Milliliters = milliliters;
        }
    }
}
