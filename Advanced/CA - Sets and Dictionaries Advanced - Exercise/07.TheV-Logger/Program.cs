using System.Collections.Generic;

namespace _07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, SortedSet<string>>> dic = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            while (command != "Statistics")
            {
                string[] info = command.Split();
                if (info[1] == "joined")
                {
                    if (!dic.ContainsKey(info[0]))
                    {
                        dic[info[0]] = new Dictionary<string, SortedSet<string>>();
                        dic[info[0]].Add("followers", new SortedSet<string>());
                        dic[info[0]].Add("following", new SortedSet<string>());
                    }

                }
                else if (info[1] == "followed")
                {
                    string first = info[0];
                    string second = info[2];
                    if (dic.ContainsKey(first) && dic.ContainsKey(second) && first != second)
                    {
                        dic[first]["following"].Add(second);
                        dic[second]["followers"].Add(first);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {dic.Count} vloggers in its logs.");
            Dictionary<string, Dictionary<string, SortedSet<string>>> orderedVloggers = dic
                .OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count)
                .ToDictionary(v => v.Key, v => v.Value);
            int count = 1;
            foreach (var vlogger in orderedVloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)



                    foreach (var follower in vlogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                count++;
            }

          
        }
    }
}