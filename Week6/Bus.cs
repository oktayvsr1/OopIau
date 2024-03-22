using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Bus
    {
        public int busId { get; set; }
        public string model { get; set; }
        public Company company { get; set; }

        public List<Passenger> passengers= new List<Passenger>();

        public void setCompany(Company c)
        {
            this.company = c;
        }

        public void addPassengers(Passenger p)
        {
            passengers.Add(p);
        }
    }
}
