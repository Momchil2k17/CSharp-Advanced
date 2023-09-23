namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dictionary = new SortedDictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision") 
            {
                string[] info = command.Split(", ").ToArray();
                string shop = info[0];
                string product= info[1];
                double price = double.Parse(info[2]);
                if (!dictionary.ContainsKey(shop))
                {
                    dictionary[shop] = new Dictionary<string, double>();
                }
                dictionary[shop][product] = price;
                command = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var kvp2 in kvp.Value) 
                {
                    Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value}");
                }

            }
        }
    }
}