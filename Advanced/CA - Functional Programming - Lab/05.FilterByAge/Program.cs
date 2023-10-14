namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ").ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                students.Add(new Student(name, age));
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Student, int, bool> filter = null;
            if (condition == "older")
            {
                filter = (student, number) => student.Age >= number;
            }
            else if ("younger" == condition)
            {
                filter = (student, number) => student.Age < number;
            }

            students = students.Where(s => filter(s, ageThreshold)).ToList();

            Action<Student> formatter = GenerateFilter(format);
            students.ForEach(formatter);

        }

        private static Action<Student> GenerateFilter(string format)
        {
            if (format == "name age")
            {
                return s => Console.WriteLine($"{s.Name} - {s.Age}");
            }
            if (format == "name")
            {
                return s => Console.WriteLine($"{s.Name}");
            }
            if (format == "age")
            {
                return s => Console.WriteLine($"{s.Age}");
            }
            return null;
        }
    }
    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}