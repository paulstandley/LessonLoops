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
            // pass by ref default pass by value
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("before the swop function is called num1 : {0} num2 : {1}", num1, num2);
            Swop(ref num1, ref num2);
            Console.WriteLine("after the swop function is called num1 : {0} num2 : {1}", num1, num2);
            Console.ReadLine();
        }
        public static void Swop(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
