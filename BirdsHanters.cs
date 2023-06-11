using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class BirdsHanters : Birds, IPredator
    {
        public BirdsHanters(string neme)
        {
            Random speed = new Random();
            SpeedFly = speed.Next(40, 80);
            Name = neme;
            Random rage = new Random();
            RageLevel = rage.Next(10, 101);
        }

        public override int SpeedFly { get; protected set; }

        public override string Name { get; set; }
        public int RageLevel { get; set; }
        public override int CompareTo(Animals? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (SpeedRun < other.SpeedRun)
            {
                return -1;
            }

            if (SpeedRun > other.SpeedRun)
            {
                return 1;
            }

            return 0;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"I'm {Name}, i can fly {SpeedFly} km/h, i'm predator,my rage level:{RageLevel}!!!");
        }
    }
}
