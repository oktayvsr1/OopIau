using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car:Vehicle,IEngine,IBody
    {
        public int numPat { get; set; }

        public Car(string make,string model,int year,int numPat):base(make,model,year)
        {
            this.numPat = numPat;
        }
       

        public override void showVehicle()
        {
            Console.WriteLine("make: "+make);
            Console.WriteLine("model: "+model);
            Console.WriteLine("year: "+year);
            Console.WriteLine("numPat: "+numPat);
            getColor();
            getTRansmission();
        }

        public void setTransmission(string transmission)
        {
            this.transmission = transmission;
        }

        public void getTRansmission()
        {
            Console.WriteLine("Transmission: "+transmission);
        }

        public void setColor(string color)
        {
            this.color= color;
        }

        public void getColor()
        {
            Console.WriteLine("Color: "+color);
        }
    }
}
