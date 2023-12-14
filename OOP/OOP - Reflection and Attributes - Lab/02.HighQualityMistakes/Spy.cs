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
        public string AnalyzeAccesModifiers(string className)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fieldsNames = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] getters = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo[] setters = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            foreach (var item in fieldsNames)
            {
                sb.AppendLine($"{item.Name} must be private!");
            }
            foreach  (var item in getters.Where(x=>x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} have to be public!");
            }
            foreach (var item in setters.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
