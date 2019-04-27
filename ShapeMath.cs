using System;

namespace LessonLoops
{
    public static class ShapeMath
    {
        public static double GetArea(
            string shape = "", 
            double length1 = 0, 
            double length2 = 0)
        {
            if(String.Equals("Rectangle", shape, StringComparison.CurrentCultureIgnoreCase))
            {
                return length1 * length2;
            }else if(String.Equals("Triangle", shape, StringComparison.CurrentCultureIgnoreCase))
            {
                return length1 * (length2 / 2);
            }else if(String.Equals("Circle", shape, StringComparison.CurrentCultureIgnoreCase))
            {
                return 3.14159 * Math.Pow(length2, 2);
            }else
            {
                return -1;
            }                  
        }
    }
}
