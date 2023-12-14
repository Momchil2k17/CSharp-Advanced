using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer
    {
        void BuyFood();
        int Food { get; }
        string Name { get; }
    }
}
