using System.Drawing;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" -> ").ToArray();
                string color = info[0];
                List<string> list = info[1].Split(",").ToList();
                if (!dic.ContainsKey(color))
                {
                    dic[color] = new Dictionary<string, int>();
                }
                foreach (var cloth in list)
                {
                    if (!dic[color].ContainsKey(cloth))
                    {
                        dic[color][cloth] = 0;
                    }
                    dic[color][cloth]++;
                }
            }
            string[] toFind = Console.ReadLine().Split();
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var clothes in kvp.Value)
                {
                    if (kvp.Key == toFind[0] && clothes.Key == toFind[1])
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }

                }
            }
        }
    }
}