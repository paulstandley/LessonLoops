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
            Animals cat = new Animals();
            Console.Write("Give the animal a nane ... ");
            cat.SetName(Console.ReadLine());
            Console.Write("Give animal a voise ... ");
            cat.Sound = Console.ReadLine();
            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Paul";
            Console.WriteLine("{0} is owned by {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0}\'s shelter id is {1}", cat.GetName(), cat.IdNum);
            Animals fox = new Animals("Mr","reeerr");
            Console.WriteLine("{0} Fox says {1}", fox.GetName(), fox.Sound);
            fox.MakeSound();
            Console.WriteLine("# of animals : {0}", Animals.NumOfAnimals);
            Console.ReadLine();
        }
   
    }
}
