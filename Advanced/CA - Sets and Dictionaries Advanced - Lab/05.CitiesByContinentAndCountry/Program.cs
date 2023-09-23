namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                string continent = info[0];
                string country = info[1];
                string city = info[2];
                if (!dic.ContainsKey(continent))
                {
                    dic[continent] = new Dictionary<string, List<string>>();
                }
                if (!dic[continent].ContainsKey(country))
                {
                    dic[continent][country] = new List<string>();
                }
                dic[continent][country].Add(city);
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var kvp2 in kvp.Value)
                {
                    string country = kvp2.Key;
                    List<string> cities = kvp2.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}