namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            while (nums.Count() < 10)
            {
                try
                {
                    if (nums.Count > 0)
                    {
                        nums.Add(ReadNumber(nums.Max(), 100));
                    }
                    else
                    {
                        nums.Add(ReadNumber(1, 100));
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (IndexOutOfRangeException ex)
                { Console.WriteLine(ex.Message); }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        public static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= start || num >= end)
            {
                throw new IndexOutOfRangeException($"Your number is not in range {start} - 100!");
            }
            return num;
        }

    }

}