using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Listmani
    {
        public static void main()
        {
            List <String > NewList = new List<String> {"Mango","apple","pineapple" };
            List<String> OldList = new List<String>(NewList);
        }
    }
}
