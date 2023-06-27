using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class Reptiles : LandAnimals, IPredator
    {
        public Reptiles(string neme)
            : base(neme)
        {
            Random speed = new Random();
            SpeedRun = speed.Next(5, 20);
            Name = neme;
            Random rage = new Random();
            RageLevel = rage.Next(10, 101);
            Random s = new Random();
            SpeedSwim = s.Next(5, 20);
        }

        public int RageLevel { get; set; }
        public new int SpeedSwim { get; private set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"I'm {Name}, i can run {SpeedRun} km/h and swim {SpeedSwim} km/h, i'm predator,my rage level:{RageLevel}!!!");
        }
    }
}
