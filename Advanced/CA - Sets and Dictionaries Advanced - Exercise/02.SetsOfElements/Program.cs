namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < sizes[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < sizes[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> combo = new HashSet<int>();
            foreach (var num1 in set1)
            {
                foreach (var num2 in set2)
                {
                    if (num1==num2)
                    {
                        combo.Add(num1);
                    }
                }
            }
                Console.WriteLine(string.Join(" ",combo));
        }
    }
}