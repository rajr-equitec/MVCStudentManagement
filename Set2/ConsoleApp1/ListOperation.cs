using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListOperation
    {
        public static void Disp()
        {

            List<String> NewList = new List<String> { "A", "B", "C" }; List<String> OldList = new List<String>(NewList);

            OldList.Add("D");
            OldList.Remove("B");

            Console.WriteLine("Original list"); foreach (var item in NewList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("New LIst"); foreach (var item in OldList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
