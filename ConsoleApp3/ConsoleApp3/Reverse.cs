using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Reverse
    {
        public static void Rev()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int newnumber = 0;
            while (n > 0)
            {
                int res = n % 10;
                newnumber = newnumber * 10 + res;
                n = n / 10;
            }

            Console.WriteLine(newnumber);
            Console.ReadLine();
        }
    }
}
