using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Patient(int ıd, string name, string surname)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
        }
    }
}
