using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Pattern
    {
        public static void Pat()
        {
            Console.WriteLine("Enter a number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());


            for (int i = 0;i<=rows ;i++ )
            {
                for (int space = 1;space<= rows-i;space++)
                {
                    Console.Write(" ");
                }
                for (int  num = 1;  num <= i;  num++)
                {
                    Console.Write(num);
                }
                for (int num = i - 1; num >= 1; num--)
                {

                    Console.Write(num);
                }
                Console.WriteLine( );
            }
        }
    }
}