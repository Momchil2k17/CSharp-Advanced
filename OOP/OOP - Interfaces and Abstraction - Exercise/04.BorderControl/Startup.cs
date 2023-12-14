namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IRobotable> society = new();
            IRobotable different=default;
            while (true) 
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }

                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Count()==3)
                {
                    different = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                }
                else if (tokens.Count()==2)
                {
                    different = new Robot(tokens[0], tokens[1]);
                }
                society.Add(different);
            }
            string last = Console.ReadLine();
            foreach (var item in society)
            {
                if (item.Id.EndsWith(last))
                {
                    Console.WriteLine(item.Id);
                }
            }

        }
    }
}