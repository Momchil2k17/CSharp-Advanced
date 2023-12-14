using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts=new List<string>();
        }

        public string Name 
        {
            get 
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            } 
        }

        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;  
            }
        }
        public List<string> BagOfProducts { get; private set; }
    }
}
