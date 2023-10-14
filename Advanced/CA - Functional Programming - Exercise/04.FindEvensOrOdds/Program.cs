namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;
            string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string type = Console.ReadLine();
            if (type=="odd")
            {
                isEven = x=>x%2!=0;
            }
            for (int i = int.Parse(tokens[0]); i <= int.Parse(tokens[1]); i++)
            {
                if (isEven(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}