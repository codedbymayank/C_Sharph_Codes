using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___34___Methods_Or_Functions___Part_1____
{
    internal class Program
    {
        //Declaring & Defining a method -> Non-static or Instance method
        public void NewMethod()
        {
            Console.WriteLine("Creating first Method");
            Console.WriteLine("Inside Class");
            Console.WriteLine("\t");
        }

        //Parameterized static Method

        public static void NameMeth(string name = "unknown")
        {
            Console.WriteLine("My Name is " + name);
            Console.WriteLine("\t");
        }

        public static void IntMethod(int no)
        {
            Console.WriteLine("Number " + no + " is input by user");
        }

        //Static Method
        public static void StMethod()
        {
            Console.WriteLine("Tukon Hanji Mei Khamakha");
            Console.WriteLine("\t");
        }

        static void Main(string[] args)
        {
            //To call a method we need to create a object of class
            Program obj = new Program();
            //Calling a method , it's reusable
            obj.NewMethod();

            //Calling static method
            Program.StMethod();

            //Calling parameterize static method
            Program.NameMeth("Mayank Pal");
            Program.NameMeth("Rudra Oberoi");
            Program.NameMeth("Omkara");
            Program.NameMeth();

            Program.IntMethod(100);

            Console.ReadLine();
            
        }


    }
}
