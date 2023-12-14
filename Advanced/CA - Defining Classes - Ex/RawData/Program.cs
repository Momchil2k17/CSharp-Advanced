namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                Engine engine= new Engine(engineSpeed,enginePower);
                int cargoWeigth = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                Cargo cargo=new Cargo(cargoType,cargoWeigth);
                double tire1Pressure = double.Parse(tokens[5]);
                int tire1Age = int.Parse(tokens[6]);
                double tire2Pressure = double.Parse(tokens[7]);
                int tire2Age = int.Parse(tokens[8]);
                double tire3Pressure = double.Parse(tokens[9]);
                int tire3Age = int.Parse(tokens[10]);
                double tire4Pressure = double.Parse(tokens[11]);
                int tire4Age = int.Parse(tokens[12]);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);
                Tire[] tires = { tire1, tire2, tire3, tire4 };
                Car c = new Car(model, engine, cargo, tires);
                cars.Add(c);
            }
            string type = Console.ReadLine();
            if (type== "fragile")
            {
                foreach (var car in cars.Where(x=>x.Cargo.Type=="fragile" && x.Tires.Any(x=>x.Pressure<1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (type== "flammable")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power>250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}