using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Polymorphism__
{
    //Method Overloading
    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }
    }

    class B
    {
        public void M1(string name)
        {
            Console.WriteLine("Method 2 : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.M1();
        }
    }
}
