using ConsoleApp3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            
            Set0 obj = new Set0();
            //Question1
            Set0.Fibo();
            //Question2
            Set0.CheckArmstrong();
            //Question3
            //a
            Set0.Anagram();
            //b
            Set0.Prime();
            //c
            Set0.Reverse();
            //d
            Set0.Sort();
            //e
            Set0.Factorial();
            //f
            Set0.ConvertNumber();
            //g
            Set0.Arrayoper();   
            
            //Question4
            Set0.CheckPalindrone();

            //Question5
            Set0.Find();

            //Question6
            Set0.MaxRepeated();

            //Question7
            Set0.Pattern();

            //Question8
            Set0.Asc();

            //Question9
            Set0.Sum();









            /*Swap.SwapNum<int> sw = Swap.WithoutThird;
            int a1 = 10;
            int b1 = 20;
            sw(ref a1 , ref b1);

            Swap.SwapNum<int> swap = Swap.WithThird;
            int a = 10;
            int b = 20;
            swap(ref a,ref b);
            Console.ReadLine(); */


            //Circle circle = new Circle(5);
            //Console.WriteLine("Radius: " + circle.Radius);
            //Console.WriteLine("Circumference: " + circle.Circumference);
            //Console.WriteLine("Area: " + circle.Area);
            //Console.ReadLine();


            /* string input = @"START-OF-FILE
 FIRMNAME = Equitec
 FILETYPE = PC
 START-OF-TICKERS
 ABB IN Equity
 CEAT IN Equity
 RIL IN Equity
 END-OF-TICKERS
 START-OF-FIELDS
 CMP
 MARKET_CAP
 START-OF-DATA
 ABB IN Equity|100|50000000
 CEAT IN Equity|20|70000000
 END-OF-DATA
 END-OF-FILE";

             DataExt data = DataExt.Parse(input);

             Console.WriteLine($"FIRMNAME: {data.FIRMNAME}");
             Console.WriteLine($"FILETYPE: {data.FILETYPE}");
             Console.WriteLine("TICKERS: " + string.Join(", ", data.TICKERS));
             Console.WriteLine("FIELDS: " + string.Join(", ", data.FIELDS));
             Console.WriteLine("DATA: " + string.Join(", ", data.DATA));
             Console.ReadLine();


             //Circles c = new Circles();
             //c.Cal();

             // Employee.Disp();
             //Fibona.Fibo();

             //Arm.cs();
             // Console.ReadLine();

             /* List<String> list = new List<String> { "A", "B", "C" };
             foreach (var i in list)
             {
                 Console.WriteLine(i);
             }*/
            //Console.ReadLine();


            //SortedL.Sorte();


            /*  for (int i = 1; i <= 5; i++)
              {
                  for (int j = 1; j <= 5; j++)
                  {
                      if (i==1||i==5||j==1||j==5)
                      {
                          Console.Write("*");
                      }
                      else { 
                      Console.Write(" ");
                      }
                  }
                  Console.WriteLine();
              }*/
            //Pratices.UserINput();
            Console.ReadLine();
        }

    }
}
