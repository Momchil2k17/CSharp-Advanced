using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        public Person() 
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this() 
        {
            Age = age;
        }
        public Person(int age, string name) : this(age) 
        {
            Name = name;
        }
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
