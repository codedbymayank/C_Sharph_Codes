using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___10___Relational_Operators__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 199;
            int b = 213;

            //Relational Operator :- < , > , != , == , >= , <=
            Console.WriteLine(a<b);
            Console.WriteLine(a>b);
            Console.WriteLine(a!=b);
            Console.WriteLine(a==b);
            Console.WriteLine(a>=b);
            Console.WriteLine(a<=b);

            Console.ReadLine(); 
        }
    }
}
