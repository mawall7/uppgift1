using System;
using System.Security.Cryptography.X509Certificates;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ehandl = new Employeehandler<Employee>();
            
            while (true)
            {
                int inp = 0 ;
                var s = 0;
                while (inp != 1 && inp != 2 && inp != 3) { 
                Console.WriteLine("1 = Add an employee   2 = List Employees 3 = quit");
                inp = int.Parse(Console.ReadLine()); }

                switch (inp)
                {
                    case 1:
                        Console.WriteLine("write name:");
                        var n = Console.ReadLine();
                        Console.WriteLine("write salary:");
                        
                        s = int.Parse(Console.ReadLine());
                        ehandl.AddEmployee(n, s);
                        Console.WriteLine("________________________________________");
                        break;
                    case 2:
                        ehandl.WriteAll();
                        Console.WriteLine("________________________________________");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                
            }
                
            //a.SetValue(1, 1);
            //foreach (var item in a)
            //{
            //int[] a = new int[2] {1,2};
            //    Console.WriteLine(item.ToString());


                       //}
        }
    }
}
