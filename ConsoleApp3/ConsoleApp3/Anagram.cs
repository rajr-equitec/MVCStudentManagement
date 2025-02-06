using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Anagram
    {
        public static void Ana()
        {
            Boolean IsAnagram = true;
            Console.WriteLine("Enter an String 1");
            String one = Console.ReadLine();
            Console.WriteLine("Enter an String 2");
            String two = Console.ReadLine();
            char[] chars = one.ToCharArray();
            char[] chars2 = two.ToCharArray();
            char temp;



            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++) {
                    if (chars[i] > chars[j])
                    {
                        temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                    }
                }

            }

            Console.WriteLine(chars);
            for (int i = 0; i < chars2.Length - 1; i++)
            {
                for (int j = i + 1; j < chars2.Length; j++)
                {
                    if (chars2[i] > chars2[j])
                    {
                        temp = chars2[i];
                        chars2[i] = chars2[j];
                        chars2[j] = temp;
                    }
                }

            }
            Console.WriteLine(chars2);

            for (int n = 0;n < chars.Length - 1; n++)
            {
                if(chars[n] != chars2[n])
                {
                   IsAnagram = false;
                }
               
            }


            Console.WriteLine(IsAnagram);
            Console.ReadLine();
        }

    }
}