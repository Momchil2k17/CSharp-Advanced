namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Console.WriteLine(orders.Max());
            int count=orders.Count();
            for (int i = 0; i < count; i++) 
            {
                if (food-orders.Peek()>=0)
                {
                    food-=orders.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: "+string.Join(" ",orders));
                    return;
                }
            }
            Console.WriteLine("Orders complete");


        }
    }
}