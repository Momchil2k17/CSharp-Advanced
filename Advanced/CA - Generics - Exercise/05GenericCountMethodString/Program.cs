using System.Security.Cryptography.X509Certificates;

namespace _05GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            Box<double> boxes = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                boxes.Add(double.Parse(value));
            }
            double toCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(boxes.Count(toCompare));
        }
        
    }
}