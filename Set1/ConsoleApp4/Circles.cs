using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Circles
    {
        public readonly Double Area;
        public readonly Double Circumference;
        public void Cal()
        {
            Console.WriteLine(" Enter a value for radius ") ;
            int radius = Convert.ToInt32(Console.ReadLine());
            Cals(radius, Area, Circumference);
        }

        public static void Cals(int radius, Double Area, Double Circumference)
        {
            Area = 3.14159 * radius * radius;
            Circumference = 2 * 3.14159 * radius;
            Console.WriteLine(Area);
            Console.WriteLine(Circumference);
            Console.ReadLine();
        }

    }
}
