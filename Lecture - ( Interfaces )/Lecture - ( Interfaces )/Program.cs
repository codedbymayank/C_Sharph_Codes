using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Interfaces__
{
    interface In1
    {
        void M1();
        
    }

    interface In2
    {
        void M1();
    }

    class A:In1 , In2
    {
        public void M1()
        {
            Console.WriteLine("Interface 1 Method");
        }

        public void M2()
        {
            Console.WriteLine("Interface 2 Method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.M1();
            obj.M2();


            Console.ReadLine();

        }
    }
}
