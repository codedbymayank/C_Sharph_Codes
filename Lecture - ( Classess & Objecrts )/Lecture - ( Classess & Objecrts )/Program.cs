using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Classess___Objecrts__
{
    class A
    {
        int somevar;
        public int m1()
        {
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Here a object is an instance of class , during creation of object we are allocating a memory
            A obj = new A();
            obj.m1();
        }
    }
}
