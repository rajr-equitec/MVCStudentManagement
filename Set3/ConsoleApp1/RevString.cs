using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RevString
    {
        public static void Rev()
        {
            String inputstring = "helloworld";
            string reversedString = Reverse(inputstring);
            Console.WriteLine(reversedString);

            int inputNumber = 12345;
            int reversedNumber = Reverse(inputNumber); 
            Console.WriteLine(reversedNumber);
        }


        public static T Reverse<T>(T input)
        {
            if (typeof(T) == typeof(string))
            {
                string strInput = input as string;
                string reversed = new string(strInput.Reverse().ToArray()); return (T)(object)reversed;
            }
            else if (typeof(T) == typeof(int))
            {
                int number = (int)(object)input;

                string reversed = new string(number.ToString().Reverse().ToArray()); return (T)(object)int.Parse(reversed);
            }
            throw new ArgumentException("Unsupported type. Only string and int are supported.");
        }

    }
}
