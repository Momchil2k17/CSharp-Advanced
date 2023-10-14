namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family f= new Family();
            
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person(int.Parse(tokens[1]), tokens[0]);
                f.AddMember(person);
            }
            List<Person> over =f.Persons.Where(p => p.Age > 30).OrderBy(n => n.Name).ToList();
            foreach (var item in over)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}