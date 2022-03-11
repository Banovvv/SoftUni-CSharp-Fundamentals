using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    internal class Program
    {
        static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            List<string> departments = new List<string>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] args = Console.ReadLine().Split();
                
                string name = args[0];
                decimal salary = decimal.Parse(args[1]);
                string department = args[2];

                departments.Add(department);

                employees.Add(new Employee(name, salary, department));
            }

            // Getting unique departments
            departments = departments.Distinct().ToList();

            decimal bestAvrgSalary = -1;
            string bestDepartment = string.Empty;

            foreach (string department in departments)
            {
                var currentAvgSalary = employees.Where(x=>x.Department == department).Average(x=>x.Salary);

                if(bestAvrgSalary < currentAvgSalary)
                {
                    bestAvrgSalary = currentAvgSalary;
                    bestDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (Employee employee in employees.Where(x=>x.Department == bestDepartment).OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
