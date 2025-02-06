using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Armstrong
    {

        public static void Arm()
        {
            int sum = 0;
            bool IsArmstrong;
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int raj = number;
            

            while (number !=0) { 
                int res = number % 10;
                sum += res * res * res;
                number = number / 10;
            }

            if (sum == raj)
            {
                IsArmstrong = true;
            }
            else
            {
                IsArmstrong = false;
            }
            Console.WriteLine(IsArmstrong);
        }
    }
}

