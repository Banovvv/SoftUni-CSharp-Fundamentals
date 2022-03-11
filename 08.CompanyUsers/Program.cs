using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] args = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                AddEmployee(companies, args);

                command = Console.ReadLine();
            }

            foreach(var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach(var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }

        public static void AddEmployee(Dictionary<string, List<string>> companies, string[] args)
        {
            string companyName = args[0].Trim();
            string employeeId = args[1].Trim();

            if (companies.ContainsKey(companyName))
            {
                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }
            }
            else
            {
                companies.Add(companyName, new List<string> { employeeId });
            }
        }
    }
}
