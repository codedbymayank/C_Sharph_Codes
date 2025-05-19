using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Inheritance___Its_Types__
{
    //For Single Inheritance 

    class Parentclass
    {
        public void M1()
        {
            Console.WriteLine("Printing from Parent Class"); ;
        }
    }

    class Childclasss : Parentclass
    {
        public void M2()
        {
            Console.WriteLine("Printing from child class");
        }
        
    }

    //For Multilevel inheritance

    class MI1
    {
        public void M1method()
        {
            Console.WriteLine("Multilevel Parent Class 1");
        }
    }

    class MI2:MI1
    {
        public void M2method()
        {
            Console.WriteLine("Multilevel child Class 2 which inherit parent class");
        }
    }


    class MI3:MI2
    {
        public void M3method()
        {
            Console.WriteLine("Multilevel child Class 2 which inherit parent class MI2");
        }
    }


    //For Herirachical Inheritance :- One class is a parent class for two child class
    class MI4: MI1
    {

    }

    class MI5 : MI1
    {

    }


    //For Multiple Inheritance

    interface I1
    {
        void InterfaceMethod1();
    }

    interface I2
    {
        void InterfaceMethod2();
    }

    class InterfaceInherit : I1 , I2
    {
        public void InterfaceMethod1()
        {
            Console.WriteLine("Interface Method 1");
        }

        public void InterfaceMethod2()
        {
            Console.WriteLine("Interface Method 2");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            //For Single Inheritance
            Childclasss obj = new Childclasss();
            obj.M1();
            obj.M2();

            //For Multilevel Inheritance
            MI2 obj2 = new MI2();
            obj2.M2method();
            obj2.M1method();

            MI3 obj3 = new MI3();
            obj3.M2method();
            obj3.M3method();




            Console.ReadLine();
        }
    }
}
