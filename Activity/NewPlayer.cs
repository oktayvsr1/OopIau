using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class NewPlayer : Footballer, IFootballClub, IPosition
    {
        public string preferredFoot { get; set; }
        public NewPlayer(string name, string surname, int birthYear,string preferredFoot) : base(name, surname, birthYear)
        {
            this.preferredFoot = preferredFoot;

        }

        public override int getAge()
        {
            
            return DateTime.Now.Year - birthYear;
        }

        

        public override void show()
        {
            Console.WriteLine("Name Surname: "+name+" "+surname);
            getFootballClub();
            getPosition();
            Console.WriteLine("Preferred Foot: "+preferredFoot);
            Console.WriteLine("Age: "+getAge());
        }

        public void setFootballClub(string clubName)
        {
            this.clubName = clubName;
        }

        public void getFootballClub()
        {
            Console.WriteLine("clubname: "+clubName);
        }

        public void setPosition(string position)
        {
            this.position = position;
        }

        public void getPosition()
        {
            Console.WriteLine("position: "+this.position);
        }
    }
}
