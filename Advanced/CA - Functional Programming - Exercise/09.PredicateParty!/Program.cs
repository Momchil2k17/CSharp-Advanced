using System.Reflection.PortableExecutable;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command=Console.ReadLine())!="Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string first = tokens[0];
                string condition = tokens[1];
                string val= tokens[2];
                if (first=="Remove")
                {
                    people.RemoveAll(GetPredicate(condition, val));
                }
                else
                {
                    List<string> toDouble = people.FindAll(GetPredicate(condition, val));
                    foreach (string s in toDouble) 
                    {
                        int index = people.FindIndex(p => p == s);
                        people.Insert(index, s);
                    }
                }
            }
            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }


        }
        private static Predicate<string> GetPredicate(string condition, string value)
        {
            switch (condition)
            {
                case "StartsWith":
                    return p=>p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length==int.Parse(value);
                default:
                    return default;
                  
            }
        }
    }

}