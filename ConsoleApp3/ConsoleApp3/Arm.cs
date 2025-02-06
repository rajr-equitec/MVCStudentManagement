using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Arm
    {
        public static void cs() {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int check = num;
            int count = 0;
            double sum = 0;
            char[] arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++) {

                count++;         
            };
           
            int n = count;
            while (num!=0)
            {
                int rem = num % 10;
                  sum += Math.Pow(rem,n);
                num = num / 10;
            }

            if (check == sum)
            {
                Console.WriteLine("Isarmstrong");
            }
            else
            {
                Console.WriteLine("Notarmstrong");
            }

        }
    }
}
