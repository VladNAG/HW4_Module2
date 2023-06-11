using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4_Module2
{
    internal class Whale : FishHanter
    {
        public Whale(string neme)
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
