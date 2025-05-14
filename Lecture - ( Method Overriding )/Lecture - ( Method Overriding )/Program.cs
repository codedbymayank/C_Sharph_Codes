using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Method_Overriding__
{
    class Parentclass
    {
        public virtual void M1()
        {
            Console.WriteLine("Parent class : Method 1");
        }

        public virtual void M2()
        {
            Console.WriteLine("For Base Keyword");
        }
    }

    class Childclass : Parentclass
    {
        public override void M1()
        {
            Console.WriteLine("Child class : Method 1");

        }

        public virtual void M2()
        {
            //For calling method which is inside parent class
            base.M2();

            Console.WriteLine("For Base Keyword");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Here basically we are overriding our parent class method 

            Childclass obj = new Childclass();
            obj.M1();

            obj.M2();

        }
    }
}
