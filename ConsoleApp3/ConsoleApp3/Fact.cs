using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Fact
    {
        public static void Factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter an number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i<=number; i++ )
            {
                 fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
