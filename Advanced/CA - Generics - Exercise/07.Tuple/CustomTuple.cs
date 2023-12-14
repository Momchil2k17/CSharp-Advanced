using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    public class CustomTuple<T1,Т2,T3>
    {
        public CustomTuple(T1 item1, Т2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public T1 Item1{ get; set; }
        public Т2 Item2{ get; set; }
        public T3 Item3{ get; set; }
        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
