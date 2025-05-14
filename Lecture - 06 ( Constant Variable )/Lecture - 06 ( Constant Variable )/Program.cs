using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___06___Constant_Variable__
{
    public class Program
    {
        //Constant Variable can be declare inside class or inside a method
        //Here constant variable is public which means it can be access anywhere
        public const double PI = 3.14;
        static void Main(string[] args)
        {
            //Constant Variable inside a method
            const int newvariable = 100;

            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
}
