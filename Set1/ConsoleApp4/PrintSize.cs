using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class PrintSize
    {
        public static void Cal()
        {
            int bol = sizeof(bool);
            int cha = sizeof(char);
            int dec = sizeof(decimal);
            int uin = sizeof(uint);
            int usho = sizeof(ushort);
            Console.WriteLine("Size of Bool:" + bol);
            Console.WriteLine("Size of char:" + cha);
            Console.WriteLine("Size of decimal:" + dec);
            Console.WriteLine("Size of uint:" + uin);
            Console.WriteLine("Size of ushort:" + usho);
            Console.ReadLine();
        }

    }
}
