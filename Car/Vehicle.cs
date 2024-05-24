using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Vehicle
    {
        public string make { get; set; }
        public string model { get; set; }
        public string transmission { get; set; }
        public string color { get; set; }
        public int year { get; set; }

        protected Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public abstract void showVehicle();
    }
}
