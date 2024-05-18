using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class Film : Production
    {
        public int boxOfficeGross { get; set; }

        public Film()
        {

        }

        public Film(string title,string director,string writer,int boxOfficeGross) : base(title, director, writer)
        {
            this.boxOfficeGross = boxOfficeGross;
        }

        public void display()
        {
            
            base.display();
            Console.WriteLine(boxOfficeGross);
        }
    }
}
