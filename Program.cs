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

            Console.ReadLine();
        }
   
    }
}
