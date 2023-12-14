namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuel = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> aditionalConsumption = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> quantity = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<string> reachedAltitudes = new();
            for (int i = 1; i <= 4; i++)
            {
                int currentFuel = fuel.Pop();
                int currentAdditonalConsumption = aditionalConsumption.Dequeue();
                int currentQuantity = quantity.Peek();
                if (currentFuel - currentAdditonalConsumption >= currentQuantity)
                {
                    Console.WriteLine($"John has reached: Altitude {i}");
                    reachedAltitudes.Add($"Altitude {i}");
                    quantity.Dequeue();
                    if (!quantity.Any())
                    {
                        Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {i}");
                    break;
                }
            }
            if (quantity.Any() && reachedAltitudes.Any())
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", reachedAltitudes)}");
            }
            else if (quantity.Any() && !reachedAltitudes.Any())
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
        }
    }
}