using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }

        public List<Doctor> doctors= new List<Doctor>();
        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }
    }
}
