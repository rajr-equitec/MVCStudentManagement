using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Fibona
    {
        public   static  void Fibo() { 
          int Fn = 0;
        int Sn = 1;
        int Nt;
            
            Console.WriteLine("ENTER A VALUE FOR n ");
        int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fn);
            Console.WriteLine(Sn);
            Fibo2(Fn,Sn,n);
          
        }
        public static   void  Fibo2(int Fn,int Sn,int n )
        {
            
            for (int i =2;i<n; i++) {
                
                int Nt = Fn + Sn;
                Console.WriteLine(Nt);
                Fn = Sn;
                Sn = Nt;
           
           
            }
        }
    }
}
