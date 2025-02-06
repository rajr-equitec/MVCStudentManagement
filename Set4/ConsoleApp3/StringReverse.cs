using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StringReverse
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter a String to reverse");
            String name = Console.ReadLine();

            String reverse = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {

                reverse += name[i];
            }
            Console.WriteLine(reverse);
        }

    }
}
