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
            Console.WriteLine("The Rectangle area of {0}", ShapeMath.GetArea("Rectangle", 20, 40));
            Console.WriteLine("The Triangle area of {0}", ShapeMath.GetArea("Triangle", 20, 40));
            Console.WriteLine("The Circle area of {0}", ShapeMath.GetArea("Circle", 20, 40));
            Console.WriteLine("The Default area of {0}", ShapeMath.GetArea("Default", 20, 40));
            // let a data type hold the null value
            int? randomNull = null;
            if(randomNull == null)
            {
                Console.WriteLine("randomNull is null");
                randomNull = 42;
            }
            if (randomNull.HasValue)
            {
                Console.WriteLine("randomNull is {0}", randomNull);
            }
            Console.ReadLine();
        }
   
    }
}
