using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift1
{
    class Employee
    {
        public string name { get; set; }
        public int salary { get; set; }
        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
    }
}
