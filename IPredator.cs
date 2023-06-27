using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public interface IPredator
    {
        public abstract int RageLevel { get; set; }
        public void Hant()
        {
            Console.WriteLine("I'm predator, I can hunts");
        }
    }
}
