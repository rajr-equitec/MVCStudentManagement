using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Dict
    {
        public static void Dictionary()
        {


            Dictionary<string, string> dictionary = new Dictionary<string, string>
{
{ "1", "Apple" },
{ "2", "Banana" },
{ "3", "Cherry" }
};




            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

    }
}
