namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice=int.Parse(Console.ReadLine());
            int gunBarrelSize=int.Parse(Console.ReadLine());
            Stack<int> bulletCount = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int originalCount = bulletCount.Count;
            Queue<int> locksCount = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int valueOfInteligence=int.Parse(Console.ReadLine());
            int shooted = 0;
            while(locksCount.Count > 0) 
            {
                if (bulletCount.Pop()<=locksCount.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksCount.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                shooted++;
                if (bulletCount.Count==0 && locksCount.Count>0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locksCount.Count}");
                    return;
                }
                if (shooted % gunBarrelSize == 0 && bulletCount.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    shooted = 0;
                }
            }
            Console.WriteLine($"{bulletCount.Count} bullets left. Earned ${valueOfInteligence-((originalCount-bulletCount.Count)*bulletPrice)}");
        }
    }
}