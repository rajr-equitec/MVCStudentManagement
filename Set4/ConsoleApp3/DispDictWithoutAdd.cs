using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class DispDictWithoutAdd
    {
        public static void Disp()
        {


            Dictionary<string, string> dictionary = new Dictionary<string, string>();



            dictionary["1"] = "Apple"; dictionary["2"] = "Banana"; dictionary["3"] = "Cherry";



            Console.WriteLine("Dictionary Contents:");
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

        }
    }
}
