using System.ComponentModel;

namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Predicate<string>> dic = new();
            string command;
            while ((command=Console.ReadLine())!="Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string first = tokens[0];
                string condition = tokens[1];
                string val = tokens[2];
                if (first=="Add filter")
                {
                    if (!dic.ContainsKey(condition+val))
                    {
                        dic.Add(condition + val, GetPredicate(condition, val));
                    }
                }
                else
                {
                    dic.Remove(condition + val);
                }
            }
            foreach (var filter in dic)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));


        }
        private static Predicate<string> GetPredicate(string condition, string value)
        {
            switch (condition)
            {
                case "Starts with":
                    return p => p.StartsWith(value);
                case "Ends with":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                case "Contains":
                    return p => p.Contains(value);
                default:
                    return default;

            }
        }
    }
}