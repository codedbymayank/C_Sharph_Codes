using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Static_Members__
{
    //Static field or variables :- these variables can be shared among all instance of class . There's only one copy of it in memory 

    class A
    {
        public static int rollno;
    }

    //Static methods :- It can only access static fields or other static methods , here this keyword wont work 
    class B
    {
        public static string name;
        public static void m1(string _name)
        {
            name = _name;
        }
    }

    //Static Properties :- It provides control access to static fields

    class C
    {
        public static int stdname;
        public int kuchbhi;
        public static int p1
        {
            get
            {
                return stdname;
                //return kucbhi ; :- this will give an eror because only static fields can be accesible over here
            }
            set
            {
                stdname = value;
            }
        }

        public int p2
        {
            get
            {
                //Here in properties normal variables are also accessible
                return stdname;
            }
            set
            {
                stdname= value;
            }
        }
    }

    /*
        static class :- can't be initiated 
        can only static members 
        static constructor can be optional , but there is not by default constructor 
     */

    static class D
    {
        static D()
        {
            Console.WriteLine("Static Constructor");
        }
    }







    internal class Program
    {
        static void Main(string[] args)
        {
            //access static field or variables 
            A.rollno = 100;

            //access static methods 
            B.m1("Omkara");
           


            Console.ReadLine();

        }
    }
}
