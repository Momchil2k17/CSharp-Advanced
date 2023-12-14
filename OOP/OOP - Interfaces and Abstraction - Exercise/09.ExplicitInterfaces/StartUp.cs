namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            List<Citizen> citizens = new();
            while ((command=Console.ReadLine())!="End")
            {
                string[] tokens =command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                citizens.Add( new Citizen(tokens[0], tokens[1], int.Parse(tokens[2])));
            }
            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}