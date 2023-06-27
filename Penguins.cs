using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class Penguins : Birds
    {
        public Penguins(string neme)
        {
            SpeedFly = 0;
            Name = neme;
            Random s = new Random();
            SpeedSwim = s.Next(5, 20);
        }

        public override int SpeedFly { get; protected set; }

        public override string Name { get; set; }
        internal new int SpeedSwim { get; set; }
        public void Swim()
        {
            Console.WriteLine($"I'm {Name}, i CAN SWIM {SpeedSwim} km/h !!!");
        }

        public override int CompareTo(Animals? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (SpeedSwim < other.SpeedSwim)
            {
                return -1;
            }

            if (SpeedSwim > other.SpeedSwim)
            {
                return 1;
            }

            return 0;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"I'm bird {Name}, i can swim {SpeedSwim} km/h, but i can't swim !!!");
        }
    }
}
