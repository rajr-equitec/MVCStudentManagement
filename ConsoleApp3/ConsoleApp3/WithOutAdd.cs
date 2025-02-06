using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class WithOutAdd
    {
        public static void DispList()
        {
            List<String> list = new List<String> { "A", "B", "C" };
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
