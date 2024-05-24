using System.Threading.Channels;

namespace LastOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1,"Oktay","Avşar","MIS");
            University unv = new University();
            //unv.addStudent(student);
            unv.getAll().ForEach(c => Console.WriteLine(c.stuId+" "+c.name+" "+c.surname+" "+c.department));
            //unv.deleteStudent(1);
            //unv.updateStudent(1,"Yunuscan","Bartık");
        }
    }
}
