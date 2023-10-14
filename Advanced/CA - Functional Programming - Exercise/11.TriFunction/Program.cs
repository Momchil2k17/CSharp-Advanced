
namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, int, bool> isBigger = (name, value) =>
            {
                return name.Sum(ch => ch) >= value;
            };
            Func<List<string>,int, Func<string, int, bool>, string> getFirst = (people,value, isBigger) => people.FirstOrDefault(x => isBigger(x, value));
            Console.WriteLine(getFirst(people,value,isBigger).ToString());
        }
    }
}