using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    internal class Sample
    {
        public static void find()
        {
            string name = "Hello how ar you ";
            char[] chars = name.ToCharArray();
            string a = "are";
            char[] chars1 = a.ToCharArray();
              bool found = false;

            for (int i = 0; i < chars.Length-1; i++)
            {
                if (chars[i] == 'a' && chars[i + 1] == 'r' && chars[i + 2] == 'e')
                {
                    found = true;
                }


            }

            if (found)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("it does not contain substring");
            }
        }
    }
}
