using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Fish:MainDish
    {
        public Fish(string name, decimal price) : base(name, price, FishGrams)
        { 
        }
        private const double FishGrams = 22;
    }
}
