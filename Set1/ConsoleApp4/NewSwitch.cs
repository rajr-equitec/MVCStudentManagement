using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class NewSwitch
    {
        public static void Userinput()
        {
            Console.WriteLine(" Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Print(n);
        }
        public static void Print(int n)
        {
            string res = "";
            res = n switch
            {
                >= 1000000 => "Millions",
                >= 1000 => "Thousands ",
                >= 100 => "Hundreds",
                >= 10 => "Tens",
         => "Units"
            };
            Console.WriteLine(res);
        }

    }
}
