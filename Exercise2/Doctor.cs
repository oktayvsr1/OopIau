using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department department = new Department();
        public List<Patient> patients = new List<Patient>();

        public void setDept(int deptId)
        {
            department.Id = deptId;
        }
    }
}
