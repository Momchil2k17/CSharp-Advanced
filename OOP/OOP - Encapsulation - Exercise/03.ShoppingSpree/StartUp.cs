using System;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] persons = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] prod = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach(string person in persons) 
            {
                string[] tokens = person.Split("=",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);
                try
                {
                    Person p = new Person(name, money);
                    people.Add(p);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            foreach(string product in prod)
            {
                string[] tokens = product.Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);
                try
                {
                    Product p = new Product(name, cost);
                    products.Add(p);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            string command;
            while ((command=Console.ReadLine())!="END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                string product = tokens[1];
                Person currentPerson = people.FirstOrDefault(x => x.Name == name);
                Product currentProduct=products.FirstOrDefault(x => x.Name == product);
                if (currentPerson != null && currentProduct!=null) 
                {
                    if (currentPerson.Money>=currentProduct.Cost)
                    {
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                        currentPerson.BagOfProducts.Add(currentProduct.Name);
                        currentPerson.Money-=currentProduct.Cost;
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }
            }
            foreach (Person person in people)
            {
                if (person.BagOfProducts.Count>0)
                { 
                    Console.WriteLine($"{person.Name} - {string.Join((", "),person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }

        }
    }
}
