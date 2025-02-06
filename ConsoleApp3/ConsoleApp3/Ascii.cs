using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Ascii
    {
        public static void Asc()
        {
            Console.WriteLine("Enter a string");
            String n = Console.ReadLine();
            for(int i = 0; i < n.Length; i++)
            {
                int asc = 0;
                asc = (char)n[i];
                Console.WriteLine(asc);
            }
        }
    }
}
