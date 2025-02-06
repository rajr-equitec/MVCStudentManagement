using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class DispList
    {
        public static void Disp()
        {
            List<String> NewList = new List<String> { "A", "B", "c" };


            List<String> OldList = new List<string>(NewList);


            foreach (var item in OldList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
