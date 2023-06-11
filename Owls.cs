using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class Owls : Keel
    {
        public Owls(string neme)
        {
            Random speed = new Random();
            SpeedFly = speed.Next(20, 40);
            Name = neme;
        }

        public override int SpeedFly { get; protected set; }

        public override string Name { get; set; }
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
            Console.WriteLine($"I'm {Name}, i can fly {SpeedFly} km/h!!");
        }
    }
}
