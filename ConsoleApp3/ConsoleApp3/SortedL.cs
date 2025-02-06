using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SortedL
    {
      
        public static void Sorte()
        {
            SortedList<int,int> st = new SortedList<int, int>();
            
            int[] arr = new int[] { 5,4,3,6,2,1};
             for (int i = 0; i < arr.Length;i++)
             {
                st.Add(arr[i],  i);
             }
            foreach (var item in st)
            {
                Console.Write(item.Key+":"+item.Value);
            }
            Console.WriteLine();
            Console.WriteLine($"The Total number of elements in Sorted list are: {st.Count}");

        }
    }
}
