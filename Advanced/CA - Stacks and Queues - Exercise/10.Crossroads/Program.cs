namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int carsPassed = 0;
            Queue<string> queue = new Queue<string>();
            while (command != "END")
            {
                if (command == "green")
                {
                    int current = greenLightDuration;
                    while (current > 0 && queue.Count > 0)
                    {
                        string car = queue.Dequeue();
                        if (current - car.Length >= 0)
                        {
                            current -= car.Length;
                            carsPassed++;
                        }
                        else if (current - car.Length + freeWindow >= 0)
                        {
                            current = 0;
                            carsPassed++;
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {car[current+freeWindow]}.");
                            return;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}