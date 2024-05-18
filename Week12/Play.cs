using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class Play : Production
    {
        public int performances { get; set; }

        public Play()
        {

        }

        public Play(string title,string director,string writer,int performances) : base(title, director, writer)
        {
            this.performances = performances;
        }

        public void display()
        {
            base.display();
            Console.WriteLine(performances);
        }


    }
}
