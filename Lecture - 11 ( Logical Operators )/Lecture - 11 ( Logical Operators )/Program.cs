using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___11___Logical_Operators__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 219;
            int num2 = 900;

            //Logical Or Conditional Operator :- && , ||

            Console.WriteLine((num1 > 0) && (num2 <= 900));
            Console.WriteLine((num1 == 10) && (num2 <= 2));
            Console.WriteLine((num1 != 1000) && (num2 == 122));
            Console.WriteLine((num1 > 0) || (num2 <= 900));
            Console.WriteLine((num1 == 10) || (num2 <= 2));
            Console.WriteLine((num1 != 1000) || (num2 == 122));


            Console.ReadLine();

        }
    }
}
