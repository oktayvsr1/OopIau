using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12._2
{
    public class Student:RegisterSTU,IAcademicID,IGrades
    {
        public int stuNumber { get; set; }

        public Student(int stuNumber,string name,string surname,int age):base(name, surname, age)
        {
            this.stuNumber = stuNumber;
        }

        public override void display()
        {
            Console.WriteLine("name: "+name);
            Console.WriteLine("surname: " + surname);
            Console.WriteLine("age: " + age);
            Console.WriteLine("stuNumber: " + stuNumber);
            getAcademicID();
            getGrades();
        }

        public void setDepartment(string department)
        {
           
            base.department = department;
        }

        public void setSection(int section)
        {
            base.section = section;
        }

        public void getAcademicID()
        {
            Console.WriteLine("section: "+section);
            Console.WriteLine("department: "+department);
        }

        public void setGrades(int quiz, int midterm, int final)
        {
            base.quiz= quiz;
            base.midterm= midterm;
            base.final= final;
        }

        public double calculateAverage()
        {
            double average = (double)(quiz * 0.1) + (double)(midterm * 0.3) + (double)(final * 0.6);
            return average;
        }

        public void getGrades()
        {
            Console.WriteLine("Quiz: "+quiz);
            Console.WriteLine("midterm: " + midterm);
            Console.WriteLine("final: " + final);
            Console.WriteLine("Average: "+calculateAverage());
        }
    }
}
