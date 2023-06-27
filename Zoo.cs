using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4_Module2
{
    public class Zoo
    {
        public Zoo()
        {
            Animals = new Animals[15];
            var hammerheadshark = new Sharks("Hammerhead Shark");
            Animals[0] = hammerheadshark;
            var tigershark = new Sharks("Tiger shark");
            Animals[1] = tigershark;
            var bluewhale = new Whale("Blue Whale");
            Animals[2] = bluewhale;
            var cachalot = new Whale("Cachalot");
            Animals[3] = cachalot;
            var plaice = new Fish("Plaice");
            Animals[4] = plaice;
            var crocodile = new Reptiles("Crocodile");
            Animals[5] = crocodile;
            var chameleon = new Reptiles("Chameleon");
            Animals[6] = chameleon;
            var lion = new Cats("Lion");
            Animals[7] = lion;
            var tiger = new Cats("Tiger");
            Animals[8] = tiger;
            var puma = new Cats("Puma");
            Animals[9] = puma;
            var aptenodytes = new Penguins("Aptenodytes");
            Animals[10] = aptenodytes;
            var eudyptes = new Penguins("Eudyptes");
            Animals[11] = eudyptes;
            var owl = new Owls("Owl");
            Animals[12] = owl;
            var eagle = new BirdsHanters("Eagle");
            Animals[13] = eagle;
            var elephant = new LandAnimals("Elephant");
            Animals[14] = elephant;
        }

        public Animals[] Animals { get; protected set; }

        public void ShowAllAnimals()
        {
            Console.WriteLine();
            Console.WriteLine("We sort animals by speed of movement!!!");
            Array.Sort(Animals);
            foreach (var a in Animals)
            {
                Console.WriteLine(a.Name);
            }
        }

        public void ShowPredator()
        {
            Console.WriteLine();
            Console.WriteLine("Warning, there are predators here:");
            foreach (var a in Animals)
            {
                if (a is IPredator)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }

        public void FindAnimal()
        {
            Console.WriteLine("Enter, how many anymals you want find ? ");
            int i = int.Parse(Console.ReadLine());
            for (int x = 0; x < i; x++)
            {
                int count = 0;
                Console.WriteLine("Enter neme animal To search:");
                while (count == 0)
                {
                    string? neme = Console.ReadLine();
                    foreach (var a in Animals)
                    {
                        if (a.Name == neme)
                        {
                            a.ShowInfo();
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("name entered incorrectly try again");
                    }
                }
            }
        }
    }
}
