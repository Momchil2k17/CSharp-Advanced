namespace ListyIteratorType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            ListyIterator<string> listyIterator = new ListyIterator<string>(items);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command=="Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}