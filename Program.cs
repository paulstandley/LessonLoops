using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LessonLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Genus Tommy = new Genus()
            {
                Name = "Tommy",
                Sound = "Meeyyoow"
            };

            Dog Patch = new Dog()
            {
                Name = "Rover",
                Sound = "Wooff",
                Sound2 = "Rarr"
            };

            Patch.Sound = "Woooooff";
            Tommy.MakeSound();
            Patch.MakeSound();

            Patch.SetGenusId(12345, "Paul Standley");
            Tommy.SetGenusId(23432, "Louise Holt");

            Patch.GetGenusId();
            Tommy.GetGenusId();

            Genus.AnimalHealth getHealth = new Genus.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));
 
            Genus monkey = new Genus()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            monkey.MakeSound();

            Genus spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooff",
                Sound2 = "Geerrrr"
            };

            spot.MakeSound();

            Console.ReadLine();
        }
   
    }
}
