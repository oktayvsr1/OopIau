using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12._2
{
    public abstract class RegisterSTU
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public int quiz { get; set; }
        public int midterm { get; set; }
        public int final { get; set; }
        public int section { get; set; }

        public RegisterSTU(string name,string surname,int age)
        {
            this.name = name;
            this.surname= surname;
            this.age = age;
        }

        public abstract void display();
       
    }
}
