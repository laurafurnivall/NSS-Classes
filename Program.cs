using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees
            List<Employee> employeeList = new List<Employee>() {
                new Employee()
                {
                EmployeeName = "Laura Furnivall",
                Position = "President",
                startDate = new DateTime(2020, 10, 25),
                 },
                new Employee()
                {
                    EmployeeName = "Corbin Furnivall",
                    Position = "Vice President",
                    startDate = new DateTime(2020, 08, 09),
                },
                new Employee()
                {
                    EmployeeName = "Frank Furnivall",
                    Position = "CEO",
                    startDate = new DateTime(2022, 08, 15),
                }
            };
            // Assign the employees to the company
            NewCompany MakeCompanyDirectory(List<Employee> employeeList)
            {
                NewCompany lamco = new NewCompany();
                lamco.CompanyName = "LamCo Inc.";
                lamco.Employees = employeeList;

                return lamco;
            }

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            void DisplayCompanyList(NewCompany company)
            {
                foreach (Employee aEmployee in company.Employees)
                {
                    Console.WriteLine($"{aEmployee.EmployeeName} is the {aEmployee.Position} at {company.CompanyName} since {aEmployee.startDate}");
                }
            }

            NewCompany lamcoCompany = MakeCompanyDirectory(employeeList);
            DisplayCompanyList(lamcoCompany);

        }
    }
}

