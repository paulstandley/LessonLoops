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
            Rectangle rect1;
            rect1.width = 200;
            rect1.length = 50;
            Console.WriteLine("the area of the rect1 is {0}", rect1.Area());
            Rectangle rect2 = new Rectangle(20, 40);
            Console.WriteLine("the area of the rect2 is {0}", rect2.Area());
            // values passed by value not ref
            rect2 = rect1;
            rect1.length = 30;
            Console.WriteLine("the area of rect1 is {0}, rect2 is {1} and rect1.Length {2}", rect1.Area(), rect2.Area(), rect1.length);
            Console.ReadLine();
        }
        struct Rectangle
        {
            public double width;
            public double length;
            // mehod constructor
            public Rectangle(double w = 1, double l = 1)
            {
                width = 1;
                length = 1;
            }
            public double Area()
            {
                return width * length;
            }
        }
    }
}
