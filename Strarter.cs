using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Module2
{
    public static class Strarter
    {
        public static void Start()
        {
            Console.WriteLine("Welcome, Zoo!");
            Zoo zoo = new Zoo();
            zoo.ShowAllAnimals();
            zoo.ShowPredator();
            zoo.FindAnimal();
        }
    }
}
