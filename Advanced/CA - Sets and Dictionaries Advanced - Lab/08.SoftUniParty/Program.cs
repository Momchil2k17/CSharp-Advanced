namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            while (command!="PARTY") 
            {
                set.Add(command);
                command=Console.ReadLine();
            }
            string end=Console.ReadLine();
            while (end!="END")
            {
                set.Remove(end);
                end = Console.ReadLine();
            }
            Console.WriteLine(set.Count);
            foreach (string s in set.OrderByDescending(x => char.IsDigit(x[0]))) 
            {
                Console.WriteLine(s);
            }
        }
    }
}