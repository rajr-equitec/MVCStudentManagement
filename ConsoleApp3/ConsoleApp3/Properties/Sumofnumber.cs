using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    internal class Sumofnumber
    {
        public static void Sum()
        {
            int sum = 0;
            int[] Arr = new int []{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            for (int i = 0; i < Arr.Length; i++) {
                if (Arr[i] % 3 == 0 && Arr[i] % 4 == 0) {

                    sum += Arr[i];
                
                }
            
            }
            Console.WriteLine(sum);
        }
    }
}
