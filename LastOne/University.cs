using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LastOne
{
    public class University
    {
        public SqlConnection getConencted()
        {
            string conString = @"Server=OKTAY\SQLEXPRESS03;Database=AvsarCar;Trusted_Connection=true;TrustServerCertificate=true";
            SqlConnection connection = new SqlConnection();
            connection.Open();
            return connection;
        }

        public List<Student> getAll()
        {
            List<Student> students = new List<Student>();

            SqlConnection connection = getConencted();
            string query = "select * from students";

            SqlCommand cmd = new SqlCommand(query,connection); 
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student stu = new Student(reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3));

                students.Add(stu);
                

            }

            return students;    

        }


        public void addStudent(Student s)
        {
            SqlConnection connection=getConencted();
            string query = "insert into students values(@stuId,@name,@surname,@department)";
            SqlCommand cmd=new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@stuId",s.stuId);
            cmd.Parameters.AddWithValue("@name", s.name);
            cmd.Parameters.AddWithValue("@surname", s.surname);
            cmd.Parameters.AddWithValue("@department", s.department);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void deleteStudent(int stuId)
        {
            SqlConnection connection=getConencted();
            string query = "delete from students where stuId=@stuId";
            SqlCommand cmd= new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@stuId",stuId);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void updateStudent(int stuId,string name,string surname)
        {
            SqlConnection connection =getConencted();
            string query = "update students set name=@name , surname=@surname where stuId=@stuId";
            SqlCommand cmd= new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@surname",surname);
            cmd.ExecuteNonQuery ();
            connection.Close();
        }
    }
}
