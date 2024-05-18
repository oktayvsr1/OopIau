using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOne
{
    public class Student
    {
        public int stuId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string department { get; set; }

        public Student(int stuId, string name, string surname, string department)
        {
            this.stuId = stuId;
            this.name = name;
            this.surname = surname;
            this.department = department;
        }
    }
}
