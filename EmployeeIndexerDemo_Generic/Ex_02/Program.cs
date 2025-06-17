using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var warpped1 = new Iwrapper();
            //var warpped2 = new Iwrapper();
            //var warpped3 = new Iwrapper();

            //warpped1.warppedInt = 1;
            //warpped2.warppedInt = 2;
            //warpped3.warppedInt = 3;

            //Console.WriteLine(warpped1.warppedInt);
            //GC.Collect();
            //Console.WriteLine(warpped2.warppedInt);
            //GC.Collect();
            //warpped3 =null;
            //GC.Collect();
            var s1= new Show();
            var s2 = new Show();
            var s3 = new Show();

            s1.Name = "Tofayel";
            Console.WriteLine(s1.Name);
            GC.Collect();
            s2.Name = "Alu Khan";
            Console.WriteLine(s2.Name);
            GC.Collect();

            Console.ReadKey();
        }
    }
    //public class Iwrapper
    //{
    //    public int warppedInt;
    //}
    public class Show
    {
        public string Name;
    }
    
}
