using System;

namespace Employer_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Pete Petenen", 0001, "Sahuri", 23000);
            employees[1] = new Employee("Pate Patenen", 0002, "Hitsari", 26000);
            employees[2] = new Employee("Aki Akinen", 0003, "Kesäpoju", 1200);
            foreach (Employee x in employees)
            {
                Console.WriteLine($"{x.PrintEmployeeInfo()} \n" +
                    $"------------------------------");

            }
            employees[0].CompareSalary(employees[1],employees[2]);
        }
    }
}
