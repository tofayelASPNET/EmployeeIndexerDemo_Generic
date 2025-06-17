using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print("Tofayel");
            p.Print(44);
            p.Print(11.44);
            p.Print<string>("Tofa");
            Console.WriteLine();
            Access a= new Access();
            a.Private("abc123");

            Console.ReadKey();
        }
    }
    public class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
    public class Access
    {
        public void Private<T>(T password)
        {
            Console.WriteLine(password);
        }
    }
}
