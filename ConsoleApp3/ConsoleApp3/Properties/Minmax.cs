using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    internal class Minmax
    {
        public static void find()
        {
            Console.WriteLine("Enter an length of an array");
            int n = Convert.ToInt32(Console.ReadLine());    
            
            int[] arr = new int[n];
            Console.WriteLine("Enter an array elements");
            for (int i = 0; i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            int max = arr[0];
            for (int i = 0; i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
