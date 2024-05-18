namespace Week12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(10,"oktay","avşar",21);
            stu1.setDepartment("Management Information Systems");
            stu1.setSection(1);
            stu1.setGrades(83,25,50);
            stu1.display();
          

        }
    }
}
