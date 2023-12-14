using _03.Cards;
using System.Net.Http.Headers;

namespace Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < tokens.Count(); i++)
            {
                try
                {
                    string[] cardTokens= tokens[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string face = cardTokens[0];
                    string suit= cardTokens[1];
                    Card c=new Card(face,suit);
                    cards.Add(c);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(string.Join(" ",cards));

        }
    }
}