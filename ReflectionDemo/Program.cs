using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Generator.GetSurprise(1);

            // Console.WriteLine(result);

            // Console.WriteLine(result.Id);

            Type type = result.GetType();
            // Type type = typeof(result); wrong!

            /* foreach (PropertyInfo propInfo in type.GetProperties())
            {
                Console.WriteLine(propInfo.Name + " = " + propInfo.GetValue(result));
            } */

            foreach (FieldInfo fInfo in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(fInfo.Name + " = " + fInfo.GetValue(result));
            }

            foreach (var m in type.GetMethods())
            {
                if (m.Name == "PrintPerson")
                {
                    m.Invoke(result, null);
                }
            }
        }
    }
}
