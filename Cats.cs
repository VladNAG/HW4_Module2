using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4_Module2
{
    public class Cats : LandAnimals, IPredator
    {
        public Cats(string neme)
            : base(neme)
        {
            Random speed = new Random();
            SpeedRun = speed.Next(30, 60);
            Name = neme;
            Random rage = new Random();
            RageLevel = rage.Next(10, 101);
        }

        public int RageLevel { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"I'm {Name}, i can run {SpeedRun} km/h, i'm predator,my rage level:{RageLevel}!!!");
        }
    }
}
