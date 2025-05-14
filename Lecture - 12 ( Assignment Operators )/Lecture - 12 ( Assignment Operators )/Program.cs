using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___12___Assignment_Operators__
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Simple Assignment Operator
            int num1 = 221;
            int num2 = num1 + 1;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //Compound Assignment Operator :- >= , <= , -= , *= , /= , %=
            Console.WriteLine(num2>=num1);
            Console.WriteLine(num2 *= num1);
            Console.WriteLine(num2 -= num1);


            Console.ReadLine(); 
        }
    }
}
