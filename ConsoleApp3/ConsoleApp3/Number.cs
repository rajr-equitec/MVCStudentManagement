using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Number
    {
        public static void User()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
         
        
      
            switch (number) {
                case 1:
                    if(number > 0 && number <= 9) Console.WriteLine("Unit");
                    break;
                case 2:
                    if (number >= 10 && number <= 99) Console.WriteLine("Tens");
                    break;
                case 3:
                    if (number >= 100 && number <= 999) Console.WriteLine("Hundred");
                    break;
                case 4:
                    if (number >= 1000 && number <= 9999) Console.WriteLine("Thousand");
                    break;
                case 5:
                    if (number >= 10000 && number <= 99999) Console.WriteLine("Ten thousand");
                    break;
                case 6:
                    if (number >= 100000 && number <= 999999) Console.WriteLine("LAKHS");
                    break;
                case 7:
                    if (number >= 1000000 && number <= 9999999) Console.WriteLine("Millions");
                    break;
               default:
                    Console.WriteLine("infinity");
                    break;
            }
            }
        }
       
    }

