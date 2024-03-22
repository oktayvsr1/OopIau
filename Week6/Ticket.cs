using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public string ticketInfo { get; set; }

        public Ticket(int ticketId, string ticketInfo)
        {
            this.ticketId = ticketId;
            this.ticketInfo = ticketInfo;
        }
    }
}
