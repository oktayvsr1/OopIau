using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2604
{
    public class Student : Person, IAcademic
    {
        
        public int StudentId { get; set; }

        public Student(int studentId,string name,string surname):base(name, surname)
        {
            StudentId = studentId;
        }

        public void display()
        {
            Console.WriteLine(StudentId);
            base.display();
        }

        public override void study()
        {
            Console.WriteLine("Student is studying");
        }

        public void sayHello()
        {
            
        }

        public void getGrades()
        {
            
        }
    }
}
