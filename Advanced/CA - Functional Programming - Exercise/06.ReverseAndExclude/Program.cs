namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n=int.Parse(Console.ReadLine());    
            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> reversed = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    reversed.Add(numbers[i]);
                }
                return reversed;
            };
            
            Func<List<int>, List<int>> exclude = numbers =>
            {
                List<int> remaining = new List<int>();
                foreach (var item in numbers)
                {
                    if (item%n!=0)
                    {
                        remaining.Add(item);
                    }
                }
                return remaining;
            };
            numbers=exclude(numbers);
            numbers = reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}