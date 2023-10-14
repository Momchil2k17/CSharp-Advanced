namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                int diplacement = -1;
                string eff = "n/a";
                if (tokens.Count() == 3)
                {
                    if (int.TryParse(tokens[2], out diplacement))
                    {

                    }
                    else
                    {
                        diplacement = -1;
                        eff = tokens[2];
                    }
                }
                if (tokens.Count() == 4)
                {
                    diplacement = int.Parse(tokens[2]);
                    eff= tokens[3];
                }
                Engine engine = new Engine(model, power, diplacement, eff);
                engines.Add(engine);

            }
            int p = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < p; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = tokens[0];
                Engine engine = engines.Find(x => x.Model == tokens[1]);
                int weight = -1;
                string color = "n/a";
                if (tokens.Count() == 3)
                {
                    if (int.TryParse(tokens[2], out weight))
                    {

                    }
                    else
                    {
                        weight = -1;
                        color = tokens[2];
                    }
                }
                else if(tokens.Count() == 4) 
                {
                    weight = int.Parse(tokens[2]);
                    color = tokens[3];
                }
                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }
            foreach (var c in cars)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}