namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            SortedDictionary<char,int> dic=new SortedDictionary<char,int>();
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (!dic.ContainsKey(symbol))
                {
                    dic[symbol] = 0;
                }
                dic[symbol]++;
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}