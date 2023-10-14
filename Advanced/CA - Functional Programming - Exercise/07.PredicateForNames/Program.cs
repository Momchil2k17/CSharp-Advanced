namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Predicate<string> checkLength = name => name.Length <= n;
            people.Where(x => checkLength(x)).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}