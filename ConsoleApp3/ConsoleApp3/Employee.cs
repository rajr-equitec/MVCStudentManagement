using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Employee
    {
        public static void Disp()
        {
            Console.WriteLine("Enter your name");
            String Name = Console.ReadLine();
            Console.Write("Enter a Joiningdate (e.g. dd/mm/yyyy): ");
            DateTime JoiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter your salary:");
            Double Salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Designation:");
            String Designation = Console.ReadLine();
            String Complet = (DateTime.Now - JoiningDate).TotalDays >= 180 ? "YES" : "NO";


            Console.WriteLine("Name:" + Name);
            Console.WriteLine("JoiningDate:" + JoiningDate.ToString("MMMM-dd,yyyy"));
            Console.WriteLine("Salary" + Salary);
            Console.WriteLine("Designation" + Designation);
            Console.WriteLine("Completed 6 months:" + Complet);
            Console.ReadLine();

        }
    }
}