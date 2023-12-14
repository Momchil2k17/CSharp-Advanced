namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            if (age>15)
            {
                Person p = new Person(name, age);
                Console.WriteLine(p);
            }
            else if(age<=15)
            {
                Child c = new Child(name, age);
                Console.WriteLine(c);
            }
        }
    }
}