using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class Fish : Animals
    {
        public Fish(string neme)
        {
            Name = neme;
            Random s = new Random();
            SpeedSwim = s.Next(5, 20);
        }

        public override string Name { get; set; }
        public new int SpeedSwim { get; protected set; }
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
            Console.WriteLine($"I'm {Name}, i can swim {SpeedSwim} km/h !!!");
        }
    }
}
