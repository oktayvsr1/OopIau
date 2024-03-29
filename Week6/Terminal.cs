using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Week6
{
    public class Terminal
    {

        List<Company> companies = new List<Company>();
        public string title { get; set; }

        

        public string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public int getInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public void newCompany()
        {
   
            Company company = new Company(getInt("Enter the comapny ıd:"),getString("Enter the comapny title"));

            this.companies.Add(company);
            Console.WriteLine("New company added with this "+company.companyId+" id");
        }

        public void newBus(int companyId)
        {
         
            Bus bus = new Bus();
            bus.busId = getInt("Enter the bus id: ");
            bus.model = getString("Enter the bus mode: ");

            //foreach(Company company in companies)
            //{
            //    if(company.companyId == companyId)
            //    {
            //        companies.Add(company);
            //    }
                
            //}
            companies.Find(c => c.companyId == companyId).buses.Add(bus);
            Console.WriteLine("New buses added with this "+bus.busId+" "+bus.model+" information");


        }
        public void newPassenger(int busId)
        {
            Passenger passenger = new Passenger();
            passenger.name = getString("Enter the passenger name: ");
            passenger.surname = getString("Enter the passenger surname: ");
            passenger.passengerId = getInt("Enter the passenger ıd: ");
            Ticket t = new Ticket(getInt("Enter the ticket ıd: "),getString("Enter the ticket info: "));
            passenger.setTicket(t);

            passenger.setTicket(new Ticket ( getInt("Enter the ticket ıd: "), getString("Enter the ticket info: ") ));
           

            //foreach(Company company in companies)
            //{
            //    foreach(Bus bus in company.buses)
            //    {
            //        if (bus.busId == busId)
            //        {
            //            bus.addPassengers(passenger);
            //        }
            //    }
            //}

            companies.ForEach(c => c.buses.Find(b => b.busId ==busId ).addPassengers(passenger));


            Console.WriteLine("New passenger added with this "+passenger.passengerId+" "+passenger.name+" "+passenger.surname);



        }


        public void getBuses()
        {
            //foreach(Company company in companies)
            //{
            //    Console.WriteLine(company.companyId+" "+company.title);
            //    foreach (Bus bus in company.buses)
            //    {
            //        Console.WriteLine(bus.busId+" "+bus.model);
            //    }
            //}
            companies.ForEach(c => c.buses.ForEach(b => Console.WriteLine(b.busId+" "+b.busId+" "+c.title)));

           
        }

        public void getBuses(int companyId)
        {
            //foreach(Company company in companies)
            //{
            //    if (company.companyId == companyId)
            //    {
            //        Console.WriteLine(company.companyId+" "+company.title);
            //        foreach (Bus bus in company.buses)
            //        {
            //            Console.WriteLine(bus.busId+" "+bus.model);
            //        }
            //    }
            //}

            companies.Find(c => c.companyId == companyId).buses.ForEach(b => Console.WriteLine(b.busId + " " + b.model+" "+b.company.title)); 
        }
        public void getPassengers()
        {
            //foreach (Company company in companies)
            //{
            //    Console.WriteLine(company.companyId+" "+company.title);
            //    foreach (Bus bus in company.buses)
            //    {
            //        Console.WriteLine(bus.busId+""+bus.model);
            //        foreach (Passenger passenger in bus.passengers)
            //        {
            //            Console.WriteLine(passenger.passengerId+" "+passenger.name+" "+passenger.surname);
            //        }
            //    }
            //}

            companies.ForEach(c => c.buses.ForEach(b => b.passengers.ForEach(p => Console.WriteLine(p.passengerId + " " + p.name + " " + p.surname+" "+b.model+" "+c.title+" "+p.ticket))));

            
           
        }
    
    }
}
