using System;
using System.Collections.Generic;
using System.Text;

namespace Employer_Program
{
    class Employee
    {
        public string name;
        public int id = 0;
        public string position;
        public double salary;
        public Employee()
        {
            this.name = "";
            this.id = 0;
            this.position = "";
            this.salary = 0;
        }
        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public string PrintEmployeeInfo()
        {
         return   $"Nimi: {this.name}, ID: {this.id}, Tehtävä: {this.position}, Palkka: {this.salary}";
            
        }
        public void CompareSalary(Employee x, Employee y)
        {
            if (this.salary > x.salary)
                Console.WriteLine($"{this.name} palkka {this.salary} on suurempi kuin {x.name} palkka {x.salary}");
            else if (this.salary < x.salary)
                Console.WriteLine($"{this.name} palkka {this.salary} on pienempi kuin {x.name} palkka {x.salary}");
            else
            {
                Console.WriteLine($"{this.name} palkka: {this.salary} on sama kuin {x.name} palkka {x.salary}");
            }
            if (this.salary > y.salary)
                Console.WriteLine($"{this.name} palkka {this.salary} on suurempi kuin {y.name} palkka {y.salary}");
            else if (this.salary < y.salary)
                Console.WriteLine($"{this.name} palkka {this.salary} on pienempi kuin {y.name} palkka {y.salary}");
            else
            {
                Console.WriteLine($"{this.name} palkka: {this.salary} on sama kuin {y.name} palkka {y.salary}");
            }
            if (y.salary > x.salary)
                Console.WriteLine($"{y.name} palkka {y.salary} on suurempi kuin {x.name} palkka {x.salary}");
            else if (y.salary < x.salary)
                Console.WriteLine($"{y.name} palkka {y.salary} on pienempi kuin {x.name} palkka {x.salary}");
            else
            {
                Console.WriteLine($"{y.name} palkka: {y.salary} on sama kuin {x.name} palkka {x.salary}");
            }
        }
    }
}
