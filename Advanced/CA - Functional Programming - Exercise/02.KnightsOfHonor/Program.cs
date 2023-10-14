namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();
            Action<string> print = n => Console.WriteLine("Sir "+n);
            people.ForEach(print);
        }
    }
}