using ConsoleApp1;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {    //Question1
        RevString.Rev();
        //Question2
        var employees = new List{
            new Employee("John", "HR", "Manager", 5500), new Employee("Alice", "IT", "Developer", 4000), new Employee("Bob", "Finance", "Analyst", 6000), new Employee("Eva", "IT", "Tester", 3000),new Employee("Mark", "Marketing", "Executive", 4500), new Employee("Sara", "HR", "Assistant", 5200) }; Console.WriteLine("Employees with a Salary > 5000:");
        foreach (var employee in employees.Where(e => e.Salary > 5000))
        {
            Console.WriteLine($"{employee.Name}, {employee.Department},{ employee.Designation}, { employee.Salary}");
        }
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name}, {employee.Department},{ employee.Designation}, { employee.Salary} ");
        }
        //Question3
        AddRemove.Disp();

    }
}