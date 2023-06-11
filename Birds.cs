using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public abstract class Birds : Animals
    {
        public abstract int SpeedFly { get; protected set; }
    }
}
