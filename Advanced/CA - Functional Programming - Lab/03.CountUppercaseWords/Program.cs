
namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, bool> isUpper = s => s[0] == s.ToUpper()[0];
            list = list.Where(isUpper).ToList();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}