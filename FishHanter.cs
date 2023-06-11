using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class FishHanter : Fish, IPredator
    {
        public FishHanter(string name)
            : base(name)
        {
            Random rage = new Random();
            RageLevel = rage.Next(10, 101);
            Random s = new Random();
            SpeedSwim = s.Next(5, 20);
            Name = name;
        }

        public int RageLevel { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"I'm {Name}, i can swim {SpeedSwim} km/h, i'm predator,my rage level:{RageLevel}!!!");
        }
    }
}
