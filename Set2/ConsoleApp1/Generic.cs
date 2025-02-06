using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Generic
    {
        class GenericClass<T>
        {

            List<T> list = new List<T>(); public void AddList(T item)
            {
                list.Add(item);
            }
            public int CountItems()
            {
                return list.Count;
            }
            public bool CheckItem(T item)
            {
                return list.Contains(item);
            }
            public void DispItems()
            {
                Console.WriteLine("Items in a list are:");
                foreach (T item in list)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
