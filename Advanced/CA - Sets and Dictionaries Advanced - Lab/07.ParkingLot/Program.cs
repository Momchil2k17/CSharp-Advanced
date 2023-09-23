namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            while (command != "END")
            {
                string[] info = command.Split(", ").ToArray();
                if (info[0] == "IN")
                {
                    set.Add(info[1]);
                }
                else if (info[0] == "OUT")
                {
                    set.Remove(info[1]);
                }
                command = Console.ReadLine();
            }
            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string s in set)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}