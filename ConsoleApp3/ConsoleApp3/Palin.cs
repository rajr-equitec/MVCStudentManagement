using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Palin
    {
        public static void Check()
        {
            Boolean Isplaindrone = true;
            Console.WriteLine("Enter a String");
            String name = Console.ReadLine();
            char[] chars = name.ToCharArray();
            int start = 0;
            int end = chars.Length-1;

            while (start<end)
            {
                if (chars[start] != chars[end])
                {
                    Isplaindrone = false;
                    break;
                }
                start ++;
                end--;
            }

            Console.WriteLine(Isplaindrone);
            Console.ReadLine();
        }
    }
}
