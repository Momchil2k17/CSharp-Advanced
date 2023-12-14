namespace NauticalCatchChallenge.IO
{
    using System;
    using NauticalCatchChallenge.IO.Contracts;
    public class Writer : IWriter
    {
        public void Write(string message) => Console.Write(message);
        string result;
        public void WriteLine(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            result += message;
            Console.WriteLine(message);
            Console.ForegroundColor= ConsoleColor.White;
          
        }
    }
}
