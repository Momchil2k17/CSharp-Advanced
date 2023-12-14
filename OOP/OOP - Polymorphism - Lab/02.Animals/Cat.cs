using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        private string name;
        private string favouriteFood;
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf()+ Environment.NewLine + "MEEOW";
        }
    }
}
