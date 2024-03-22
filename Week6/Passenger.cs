using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Passenger
    {

        public int passengerId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Ticket ticket { get; set; }
        public void setTicket(Ticket t)
        {
            this.ticket = t;
        }
        
    }
}
