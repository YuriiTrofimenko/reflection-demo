using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Person
    {
        private int id;
        public string Name { get; set; }
        public void PrintPerson() {
            Console.WriteLine(ToString());
        }
    }
}
