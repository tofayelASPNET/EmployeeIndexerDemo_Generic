using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee(101,"Tofayel","Hr","Manager","dhaka",33333);
            Console.WriteLine($"Emp Id : {emp[1]}");
            Console.WriteLine($"Emp Name : {emp[2]}");
            Console.WriteLine($"Emp Designation : {emp[3]}");
            Console.WriteLine($"Emp Department : {emp[4]}");
            Console.WriteLine($"Emp Location : {emp[5]}");
            Console.WriteLine($"Emp Salary : {emp[6]}");

            Console.WriteLine();
            Console.WriteLine("************************");
            emp[1] = 102;
            emp[2] = "Ajmir";
            emp[3] = "Manager";
            Console.WriteLine($"Emp Id : {emp[1]}");
            Console.WriteLine($"Emp Name : {emp[2]}");
            Console.WriteLine($"Emp Designation : {emp[3]}");

            Console.WriteLine();
            Console.WriteLine("************************");
            emp[1] = 103;
            emp[2] = "Ashik";
            emp[3] = "Worker";
            Console.WriteLine($"Emp Id : {emp[1]}");
            Console.WriteLine($"Emp Name : {emp[2]}");
            Console.WriteLine($"Emp Designation : {emp[3]}");

            Console.ReadKey();
        }
    }
}
