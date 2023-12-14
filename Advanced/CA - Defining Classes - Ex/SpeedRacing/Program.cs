using System.Reflection;

namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++) 
            {
                string[] tokens=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();  
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1km = double.Parse(tokens[2]);
                cars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km, 0));
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car c = cars.Find(x => x.Model == tokens[1]);
                c.CanDrive(double.Parse(tokens[2]));
                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}