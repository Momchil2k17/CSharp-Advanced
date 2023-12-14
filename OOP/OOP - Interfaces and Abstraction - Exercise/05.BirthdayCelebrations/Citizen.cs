using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen: IIdentifable,IBirthtable,INameable
    {
        public Citizen(string name, int age, string id,string birth)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birth;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }

    }
}
