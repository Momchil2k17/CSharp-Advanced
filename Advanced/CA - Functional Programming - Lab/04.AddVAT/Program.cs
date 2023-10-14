
namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            Func<double, double> vat = x => x *= 1.2;
            nums=nums.Select(vat).ToList();
            foreach(double x in nums) 
            {
                Console.WriteLine($"{x:f2}");
            }
        }
    }
}