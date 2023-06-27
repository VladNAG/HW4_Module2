using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
   public class LandAnimals : Animals
    {
        public LandAnimals(string neme)
        {
            Random speed = new Random();
            SpeedRun = speed.Next(40, 80);
            Name = neme;
        }

        public override string Name { get; set; }
        public new virtual int SpeedRun { get; internal set; }
        public virtual void Run()
        {
            Console.WriteLine("I can run!!!");
        }

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
            Console.WriteLine($"I'm {Name}, i can ran {SpeedRun} km/h!!");
        }
    }
}
