using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public class Sharks : FishHanter
    {
        public Sharks(string neme)
            : base(neme)
        {
            Name = neme;
            Random rage = new Random();
            RageLevel = rage.Next(10, 101);
            Random s = new Random();
            SpeedSwim = s.Next(5, 20);
        }
    }
}
