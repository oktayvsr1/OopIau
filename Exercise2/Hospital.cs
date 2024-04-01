using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Hospital
    {
        public string Title { get; set; }
        public string City { get; set; }

        public List<Department> departments= new List<Department>();

        public string getString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public int getInteger(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void newDepartment()
        {
            Department department = new Department();
            department.Id = getInteger("Departmen ID? ");
            department.Title = getString("Departmnt title? ");
            department.City = getString("Department city? ");

            departments.Add(department);
            Console.WriteLine(department.Title+" added");
        }
        void newDoctor(int deptId)
        {
            Doctor doctor = new Doctor();
            doctor.Id = getInteger("Doctor Id? ");
            doctor.Name = getString("Doctor name? ");
            doctor.Surname = getString("Doctor Surname? ");
            doctor.patients = new List<Patient>();
            doctor.department= new Department();


            foreach (Department department in departments)
            {
                if (department.Id == deptId)
                {
                    department.addDoctor(doctor);
                    Console.WriteLine("Doctor added with this department ıd " + deptId);
                }
            }
        }

        void newPatients(int doctorId)
        {
            Patient patient = new Patient(getInteger("Patient Id? "), getString("Patient name? "), getString("Patient surname? "));
            foreach (Department department in departments)
            {
                foreach (Doctor doctor in department.doctors)
                {
                    if (doctorId == doctor.Id)
                    {
                        doctor.patients.Add(patient);
                    }
                }
            }

            departments.ForEach(d => { d.doctors.Find(doctor => doctor.Id == doctorId).patients.Add(patient); }) ;
        }

        void getDepartments()
        {
            //foreach (Department department in departments)
            //{
            //    Console.WriteLine(department.Title+" "+department.Id+" "+department.City);
            //}

            departments.ForEach(d => Console.WriteLine(d.Title + " " + d.Id + " " + d.City));
        }

        void getDepartment(int deptId)
        {
            foreach(Department department in departments)
            {
                if(deptId == department.Id)
                {
                    Console.WriteLine(department.Title + " " + department.Id + " " + department.City);
                }
            }

            departments.FindAll(d => d.Id == deptId).ForEach(d =>
            {
                Console.WriteLine(d.Title + " " + d.Id + " " + d.City);
                
            });
        }

        void getDoctors(int deptId)
        {
            foreach(Department department in departments)
            {
                if(deptId == department.Id)
                {
                    foreach(Doctor doctor in department.doctors)
                    {
                        Console.WriteLine(doctor.Name+" "+doctor.Surname+" "+doctor.Id);
                    }
                }
            }
        }

        void getDoctor(int doctorId)
        {
            foreach(Department department in departments)
            {
                foreach(Doctor doctor in department.doctors)
                {
                    if(doctorId == doctor.Id)
                    {
                        Console.WriteLine(doctor.Name + " " + doctor.Surname + " " + doctor.Id);
                    }
                }
            }
        }

        void getPatients()
        {
            foreach(Department department in departments)
            {
                foreach(Doctor doctor in department.doctors)
                {
                    foreach(Patient patient in doctor.patients)
                    {
                        Console.WriteLine(patient.Name+" "+patient.Surname+" "+patient.Id);
                    }
                }
            }
        }

        void getPatients(int deptId)
        {
            foreach(Department department in departments)
            {
                if (deptId == department.Id)
                {
                    Console.WriteLine(department.Id+" "+department.Title+" "+department.City);
                    foreach (Doctor doctor in department.doctors)
                    {
                        Console.WriteLine(doctor.Name+" "+doctor.Surname+" "+doctor.Id);
                        foreach (Patient patient in doctor.patients)
                        {
                            Console.WriteLine(patient.Name + " " + patient.Surname + " " + patient.Id);
                        }
                    }
                }
            }
        }



    }
}
