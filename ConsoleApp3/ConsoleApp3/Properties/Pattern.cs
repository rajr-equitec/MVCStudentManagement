using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    internal class Pattern
    {
       
           public  static void Pat() { 
            {
                int val = 5;
                int i, j, k;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
        }
    }
}
