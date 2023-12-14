using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            while (command!="No more tires")
            {
                string[] tokens = command.Split(" ").ToArray();
                List<Tire> tiresList = new List<Tire>();
                for (int i = 0; i < 8; i+=2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1]);
                    Tire tire = new Tire(year,pressure);
                    tiresList.Add(tire);
                }
                tires.Add(tiresList.ToArray());
                command= Console.ReadLine();
            }
            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string command2 = Console.ReadLine();
                if (command2 == "Engines done")
                {
                    break;
                }

                string[] enginesData = command2.Split();
                int horsePower = int.Parse(enginesData[0]);
                double cubicCapacity = double.Parse(enginesData[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }
            List<Car> cars = new();
            string car = Console.ReadLine();
            while (car!= "Show special")
            {
                string[] tokens = car.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                Car currCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(currCar);
                car = Console.ReadLine();
            }
            Func<Car, bool> filter = c => c.Year >= 2017 &&
                                          c.Engine.HorsePower > 330 &&
                                          c.Tires.Sum(t => t.Pressure) >= 9 &&
                                          c.Tires.Sum(t => t.Pressure) <= 10;
            List<Car> specialCars = new List<Car>();
            foreach (Car c in cars.Where(filter))
            {
                c.Drive(20);
                specialCars.Add(c);
            }

            Console.WriteLine(String.Join("", specialCars));
        }
    }
}
