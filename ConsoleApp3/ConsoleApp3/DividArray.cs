using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class DividArray
    {
        public static void Arrayoper()
        {
            Console.WriteLine("Enter the Length:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDivisible = true;

            
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[j] % arr[i] != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result = arr[i];
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
