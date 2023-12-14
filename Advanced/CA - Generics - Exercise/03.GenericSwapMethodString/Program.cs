namespace _03.GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int[] swappers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Swap(swappers[0], swappers[1], list);
            Print(list);
        }

        static void Swap<T>(int v1, int v2, List<T> items)
        {
            T temp = items[v1];
            items[v1] = items[v2];
            items[v2] = temp;
        }
        static void Print<T>(List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{typeof(T)}: {item}");
            }
        }
    }
}