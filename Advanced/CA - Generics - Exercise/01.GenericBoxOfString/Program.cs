namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string info= Console.ReadLine();
                Box<string> box = new Box<string>(info);
                Console.WriteLine(box.ToString());
            }
        }
    }
}