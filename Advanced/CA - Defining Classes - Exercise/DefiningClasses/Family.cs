using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> persons;
        public List<Person> Persons { get => persons; set => persons = value; }
        public Family()
        {
            this.Persons = new();
        }
        public void AddMember(Person member) 
        {
            Persons.Add(member);
        }
        public Person GetOldestMember()
        {
            return Persons.MaxBy(p => p.Age);
        }
      
    }
}
