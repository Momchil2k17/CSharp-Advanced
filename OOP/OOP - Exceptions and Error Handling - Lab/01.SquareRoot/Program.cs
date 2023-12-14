using System.Diagnostics.Contracts;

namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new ArithmeticException("Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Goodbye."); }
        }
    }
}