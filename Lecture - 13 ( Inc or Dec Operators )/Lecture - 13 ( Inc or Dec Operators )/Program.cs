using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___13___Inc_or_Dec_Operators__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1002;
            int m = 213;

            //First assign then increase which is post increment
            int k = n++;
            Console.WriteLine(k);

            // Pre Increment
            int j = ++n;
            Console.WriteLine(j);

            Console.ReadLine();


            
        }
    }
}
