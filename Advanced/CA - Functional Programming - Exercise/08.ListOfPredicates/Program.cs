namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, List<int>> createRange = end =>
            {
                List<int> range = new List<int>();
                for (int i = 1; i <= end; i++) 
                {
                    range.Add(i);
                }
                return range;
            };
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            int endRange = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();
            foreach (var divider in dividers)
            {  
                predicates.Add(n => n % divider == 0);
            }
            List<int> numbers=createRange(endRange);
            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}