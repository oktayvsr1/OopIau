using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Company
    {
        public int companyId { get; set; }
        public string title { get; set; }
        public List<Bus> buses { get; set; }

        public Company(int id,string title)
        {
            this.companyId = id;
            this.title = title;
        }
    }
}
