using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args) 
        {
            List<IBirthtable> society = new();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "Citizen":
                        IBirthtable citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                        society.Add(citizen);
                        break;
                    case "Pet":
                        IBirthtable pet = new Pet(tokens[1], tokens[2]);
                        society.Add(pet);
                        break;
                }
            }

            string year = Console.ReadLine();

            foreach (var element in society)
            {
                if (element.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(element.Birthdate);
                }
            }
        }
    }
}
