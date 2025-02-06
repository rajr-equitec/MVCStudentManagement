using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Properties
{
    internal class Repeat
    {
        public static void main()
        {
            int res = 0;
            char rep  = ' ';
            
            Console.WriteLine("Enter an String");
            String name = Console.ReadLine();
            
            for (int i=0;i<name.Length;i++)
            {
                int counter = 0;
                for (int j= 0; j< name.Length;j++)
                {
                     
                    if (name[i] == name[j])
                    {
                       
                        counter++;

                    }
                 
                    if (counter>res)
                    {
                        res = counter;
                        rep = name[j];
                    }

                }
            }

            Console.WriteLine(rep);
            Console.ReadLine();


        }
    }
}
