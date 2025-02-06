using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Conver
    {
        public static void Con()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            String final = "";
            while (n > 0)
            {
                int res = n % 10; 
                string result = "";

                
                switch (res)
                {
                    case 0: result = "Zero"; break;
                    case 1: result = "One"; break;
                    case 2: result = "Two"; break;
                    case 3: result = "Three"; break;
                    case 4: result = "Four"; break;
                    case 5: result = "Five"; break;
                    case 6: result = "Six"; break;
                    case 7: result = "Seven"; break;
                    case 8: result = "Eight"; break;
                    case 9: result = "Nine"; break;
                }

        
                final = result + " " + final;
                n = n / 10; 

            }
         
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}
