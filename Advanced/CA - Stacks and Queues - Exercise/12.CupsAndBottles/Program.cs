namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int wastedWater = 0;
            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentCup=cups.Dequeue();
                int currentBotlle=bottles.Pop();
                if (currentCup <=currentBotlle)
                {
                    wastedWater += (currentBotlle - currentCup);
                }
                else
                {
                    currentCup -= currentBotlle;
                    while (currentCup > 0) 
                    { 
                        currentCup-=bottles.Pop();
                        if (currentCup<0)
                        {
                            wastedWater += currentCup * -1;
                        }
                    }
                }
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}