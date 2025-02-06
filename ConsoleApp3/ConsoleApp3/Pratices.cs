using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Pratices
    {
        public static void UserINput()
        {
           Console.WriteLine("Enter a length of an array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter an array elements:");
            for (int i = 0; i < n; i++) {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Checks(arr);

           
        }
        public static void Checks(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                int temp;
                for (int j = 0; j < arr.Length; j++) { 
                
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                }
            }
            int[] newarr = new int[arr.Length];
            int even = 0;
            int odd = 1;
            for (int i = 0; i<arr.Length; i++) {
                if (arr[i] > 0)
                {
                    newarr[even] = arr[i];
                    even += 2;
                }
                else
                {
                    newarr[odd] = arr[i];
                    odd += 2;
                }
            
            }
            for (int i = 0; i < newarr.Length; i++) { 
            
            Console.WriteLine(newarr[i]);
            }
            
        }
}
}
