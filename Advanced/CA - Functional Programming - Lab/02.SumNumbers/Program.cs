namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}