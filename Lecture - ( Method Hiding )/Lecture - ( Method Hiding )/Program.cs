using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Method_Hiding__
{
    class pclass
    {
        public new void m1()
        {
            Console.WriteLine("Parent class method");
        }
    }

    class cclass : pclass
    {
        public new  void m1()
        {
            Console.WriteLine("Child class method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cclass obj = new cclass();
            obj.m1();

            Console.ReadLine();

        }
    }
}
