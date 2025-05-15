using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Access_Modifiers__
{
    //For Public
    class A
    {
        public void M1()
        {
            Console.WriteLine("Method M1");
        }
    }

    //For Protected
    class B
    {
        protected void M2()
        {
            Console.WriteLine("Method M2");
        }
    }

    //For Private
    class C
    {
        private void M3()
        {
            Console.WriteLine("Method M2");
        }
    }

    //For Internal
    class D
    {
        internal void M4()
        {
            Console.WriteLine("Method M2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
