using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CreateString
    {
        public static void Disp()
        {


            List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };




            stringList.Insert(3, "Date");

            stringList.Insert(4, "Elderberry");




            Console.WriteLine("Elements in the list:"); foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
        }
    }

}

