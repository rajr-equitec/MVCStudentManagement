using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SwapUsingDel
    {
        public delegate void SwapNum<T>(ref T a, ref T b);

          public static void WithThird<T>(ref T a, ref T b)
{
T temp = a;
        a = b;
b = temp;

Console.WriteLine(a + "," + b);
}
    public static void WithoutThird(ref int a1, ref int b1)
    {
        a1 = a1 + b1;
        b1 = a1 - b1;
        a1 = a1 - b1;
        Console.WriteLine(a1 + ", " +b1);
    }
}
}
