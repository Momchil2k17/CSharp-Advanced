using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public override string ToString() 
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal parcentage)
        {
            if (Age<30)
            {
                Salary += Salary * parcentage / 200;
            }
            else
            {
                Salary += Salary * parcentage/100;
            }
        }
    }
}
