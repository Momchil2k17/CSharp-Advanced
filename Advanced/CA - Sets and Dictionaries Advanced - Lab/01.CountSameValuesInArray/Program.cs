namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double,int> dictionary= new Dictionary<double,int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = 0;
                }
                dictionary[nums[i]]++;
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}