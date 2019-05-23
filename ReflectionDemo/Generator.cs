using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Generator
    {
        public static dynamic GetSurprise(int _case) {

            switch (_case)
            {
                case 1: {
                    return new Person() { Name = "John" };
                }
                case 2:
                {
                    return new { Id = 2, Name = "Ivan", Age = 30 };
                }
                case 3:
                {
                    return new { Data = new Person() { Name = "Yurii" }, Process = new Action(Generator.PrintAPerson) };
                }
                default:
                return null;
            }
        }

        public static void PrintAPerson()
        {
            Console.WriteLine("Stub");
        }
    }
}
