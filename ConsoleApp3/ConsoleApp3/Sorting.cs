using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Sorting
    {
        public static void Sort()
        {
            Console.WriteLine("Enter an String 1");
            String one = Console.ReadLine();
      
            char[] chars = one.ToCharArray();
           
            char temp;



            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                    }
                }

            }

            Console.WriteLine(chars);
            Console.ReadLine();
        }
    }
}
