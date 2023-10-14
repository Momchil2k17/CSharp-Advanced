using System.Collections.Generic;
using System.Threading.Channels;

namespace _03._CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<List<int>, int> getMin = numbers =>
            {
                int min = int.MaxValue;
                foreach (var item in numbers)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(getMin(numbers));
        }

    }
}