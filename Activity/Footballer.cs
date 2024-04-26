using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public abstract class Footballer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string clubName { get; set; }
        public string position { get; set; }
        public int birthYear { get; set; }

        protected Footballer(string name, string surname, int birthYear)
        {
            this.name = name;
            this.surname = surname;
            this.birthYear = birthYear;
        }

        public abstract void show();
        public abstract int getAge();
    }
}
