using System.Drawing;

namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, SortedSet<string>> forceBook = new();
            while (command != "Lumpawaroo")
            {

                if (command.Contains('|'))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!forceBook.Values.Any(u => u.Contains(user)))
                    {
                        if (!forceBook.ContainsKey(side))
                        {
                            forceBook.Add(side, new SortedSet<string>());
                        }

                        forceBook[side].Add(user);
                    }
                }
                else
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(tokens[0]))
                        {
                            forceBook[item.Key].Remove(tokens[0]);
                            break;
                        }
                    }
                    if (!forceBook.ContainsKey(tokens[1]))
                    {
                        forceBook.Add(tokens[1], new SortedSet<string>());
                    }
                    forceBook[tokens[1]].Add(tokens[0]);
                    Console.WriteLine($"{tokens[0]} joins the {tokens[1]} side!");

                }
                command = Console.ReadLine();
            }
            foreach (var kvp in forceBook.OrderByDescending(x => x.Value.Count))
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (var name in kvp.Value)
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
            }
        }
    }
}