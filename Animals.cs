using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public abstract class Animals : IComparable<Animals>
    {
        public abstract string Name { get; set; }
        public int SpeedRun { get; internal set; }
        public int SpeedSwim { get; internal set; }

        public abstract int CompareTo(Animals? other);
        public abstract void ShowInfo();
    }
}
