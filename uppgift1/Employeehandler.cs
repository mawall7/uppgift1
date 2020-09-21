using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace uppgift1
{
    class Employeehandler<T>
    {
        public string name { get; set; }
        public int salary { get; set; }

        public List<Employee> elist = new List<Employee>();
        public Employee AddEmployee(string name, int salary)
        {
            
            
            if (elist.Count == 0 || Namesearch(name) == false){
                Employee e = new Employee(name, salary);
                elist.Add(e);
            }
            return null;
        }

        public bool Namesearch(string name)
        {
            bool f = true;
            foreach (var item in elist)
            {
                if (item.name == name)
                {
                    f = true;
                    
                }

                else
                    f = false;
            }
            return f;         
        }
        public void WriteAll()
        {
            
            foreach (var item in elist)
            {
                Console.WriteLine($"Name:{item.name}, Salary:{item.salary}");

            }
        }
    }
}
