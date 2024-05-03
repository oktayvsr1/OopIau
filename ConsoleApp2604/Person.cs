using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2604
{
    public abstract class Person
    {
        public string name { get; set; }
        public string surname { get; set; }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void display()
        {
            Console.WriteLine(name+" "+surname);
        }

        public abstract void study();
    }
}
