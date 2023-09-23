namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemical = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                foreach (string s in info) 
                {
                    chemical.Add(s);
                }
            }
            Console.WriteLine(string.Join(" ",chemical.OrderBy(x=>x)));
        }
    }
}