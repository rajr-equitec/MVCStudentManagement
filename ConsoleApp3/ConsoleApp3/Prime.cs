using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Prime
    {
        public static void Pri()
        {
             Boolean IsPrime = true;
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i<n;i++)
            {
                if(n%i != 0)
                {
                    IsPrime = false;
                }
            }

            Console.WriteLine(IsPrime);
            Console.ReadLine();


        }
    }
}
