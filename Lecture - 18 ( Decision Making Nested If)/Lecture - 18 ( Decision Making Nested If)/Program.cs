using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___18___Decision_Making_Nested_If_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested If :- One If statement inside another if statement

            int no = 182; 
            if (no < 200)
            {
                if (no == 182)
                {
                    Console.WriteLine("Mil Gaya be");
                }
                else
                {
                    Console.WriteLine("Nahi Mila");
                }
            }

            Console.ReadLine();
        }
    }
}
