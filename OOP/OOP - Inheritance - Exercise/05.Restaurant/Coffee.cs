using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        private const decimal CoffeePrice = 3.50M;
        private const double CoffeeMilliliters = 50;    
        public double Caffeine { get; set; }
    }
}
