using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        public Citizen(string name, int age, string id, string birhtdate)
        {
            Name = name;
            Age = age;
           Id = id; 
            Birthdate = birhtdate;
        }

        public string Name { get;  set; }
        public int Age { get ; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
    }
}
