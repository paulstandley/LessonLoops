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
            // enum a custum data type for key value paires
            CarColor car1 = CarColor.bule;
            PaintCar(car1);
            Console.ReadLine();
        }
        enum CarColor : byte
        {
            orange = 1,
            green,
            bule,
            red,
            black
        }
        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car is painted {0} and the index is {1}", cc, (int)cc);
        }
    }
}
