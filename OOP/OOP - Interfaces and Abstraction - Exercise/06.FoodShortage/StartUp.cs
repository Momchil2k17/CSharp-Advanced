namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            IBuyer buyer = null;
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Count()==4)
                {
                    buyer=new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                }
                else if (tokens.Count()==3)
                {
                    buyer = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                }
                buyers.Add(buyer);
            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name=="End")
                {
                    break;
                }

                buyers.FirstOrDefault(x => x.Name == name)?.BuyFood();
            }
            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}