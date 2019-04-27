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
            Animalcs Fox = new Animalcs()
            {
                name = "Red",
                sound = "Raaaarrrww"
            };
            Console.WriteLine("Get how many animals were created {0}", Animalcs.GetNumAnimals());
            Fox.MakeSound();
            Fox.sound = "Woooo";
            Fox.MakeSound();
            Console.WriteLine("{0} is an animal that says {1}", Fox.name, Fox.sound);
            Console.ReadLine();
        }
   
    }
}
