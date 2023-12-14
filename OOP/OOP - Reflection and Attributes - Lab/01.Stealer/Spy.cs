using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields) 
        {
            Type type = Type.GetType(className);
            FieldInfo[] fieldsNames = type.GetFields((BindingFlags)60);
            var classInstance=Activator.CreateInstance(type,new object[] { });
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {className}");

            foreach (var item in fieldsNames.Where(x=> fields.Contains(x.Name)))
            {
                sb.AppendLine($"{item.Name} = {item.GetValue(classInstance)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
