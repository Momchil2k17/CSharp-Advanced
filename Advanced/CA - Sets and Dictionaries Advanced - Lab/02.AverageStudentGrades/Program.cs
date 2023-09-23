namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n=int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> dictionary = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                if (!dictionary.ContainsKey(info[0])) 
                {
                    dictionary[info[0]] = new List<decimal>();
                }
                dictionary[info[0]].Add(decimal.Parse(info[1]));
            }
            foreach (var kvp in dictionary)
            {
                List<decimal> grades= kvp.Value;
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ",grades.Select(grade=>$"{grade:F2}"))} (avg: {kvp.Value.Average():f2})");
            }
        }
    }
}