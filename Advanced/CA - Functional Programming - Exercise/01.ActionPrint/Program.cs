namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();
            Action<string> print = n=>Console.WriteLine(n);
            people.ForEach(print);
        }
    }
}