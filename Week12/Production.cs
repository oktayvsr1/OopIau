using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class Production
    {
        public string title { get; set; }
        public string director { get; set; }
        public string writer { get; set; }

        public Production()
        {

        }

        public Production(string title, string director, string writer)
        {
            this.title = title;
            this.director = director;
            this.writer = writer;
        }

        public void display()
        {
            Console.WriteLine(title+"\n "+director+"\n "+writer+"\n");
        }
    }
}
