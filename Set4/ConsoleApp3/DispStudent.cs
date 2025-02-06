using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RollNo { get; set; }

        public Student(string name, string address, int rollNo)
        {
            Name = name; Address = address; RollNo = rollNo;
        }


        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Roll No: {RollNo}");

        }


    }
}

