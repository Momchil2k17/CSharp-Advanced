namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count > 0) 
            {
                string command = Console.ReadLine();
                if (command.Substring(0,3)=="Add")
                {
                    string song = command.Substring(4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                            songs.Enqueue(song);
                    }
                }
                else if (command.Substring(0,4)=="Play")
                {
                    songs.Dequeue();
                }
                else if (command.Substring(0, 4) == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}