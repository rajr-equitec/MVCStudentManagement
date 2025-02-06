using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string department, string designation, decimal salary)
        {
            Name = name; Department = department; Designation = designation; Salary = salary;
        }

    }
}
