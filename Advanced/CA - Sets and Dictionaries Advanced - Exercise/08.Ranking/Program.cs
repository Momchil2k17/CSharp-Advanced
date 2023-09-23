namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string com1 = Console.ReadLine();
            Dictionary<string,string> contestAndPasswords= new Dictionary<string,string>();

            while (com1 != "end of contests") 
            {
                string[] info=com1.Split(":").ToArray();
                string contest = info[0];
                string password = info[1];
                if (!contestAndPasswords.ContainsKey(contest))
                {
                    contestAndPasswords[contest] = password;
                }
                com1 = Console.ReadLine();
            }

            Dictionary<string,Dictionary<string,int>> participants=new Dictionary<string,Dictionary<string,int>>();
            string com2 = Console.ReadLine();

            while (com2!= "end of submissions")
            {
                string[] info = com2.Split("=>").ToArray();
                string contest = info[0];
                string password = info[1];
                string username = info[2];
                int points = int.Parse(info[3]);

                if (contestAndPasswords.ContainsKey(contest) && contestAndPasswords[contest]==password)
                {
                    if (!participants.ContainsKey(username))
                    {
                        participants[username] = new Dictionary<string, int>();
                    }
                    if (!participants[username].ContainsKey(contest))
                    {
                        participants[username][contest] = points;
                    }
                    else if (participants[username].ContainsKey(contest) && points> participants[username][contest])
                    {
                        participants[username][contest] = points;
                    }
                }
                com2= Console.ReadLine();
            }
            string bestCandidate = participants.MaxBy(c => c.Value.Values.Sum()).Key;

            int bestCandidateTotalPoints = participants[bestCandidate].Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateTotalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var participant in participants.OrderBy(x=>x.Key))
            {
                Console.WriteLine(participant.Key);
                foreach (var points in participant.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
    }
}