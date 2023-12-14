using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cards
{
    public class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get { return face; }
            set
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    if (number < 2 || number > 10)
                    {
                        throw new ArgumentException("Invalid card!");
                    }
                }
                else if (value != "J" && value != "K" && value != "Q" && value != "A")
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value;
            }
        }
        public string Suit
        {
            get { return suit; }
            set 
            {
                if (value != "S" && value != "H" && value != "D" && value != "C")
                {
                    throw new ArgumentException("Invalid card!");
                }
                suit = value;
            }
        }
        public override string ToString()
        {
            if (Suit == "S")
            {
                return $"[{Face}\u2660]";
            }
            else if (Suit == "H")
            {
                return $"[{Face}\u2665]";
            }
            else if (Suit == "D")
            {
                return $"[{Face}\u2666]";
            }
            else if (Suit == "C")
            {
                return $"[{Face}\u2663]";
            }
            else { return null; }
        }


    }
}
