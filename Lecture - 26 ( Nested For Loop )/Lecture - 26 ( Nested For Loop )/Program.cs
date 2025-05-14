using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___26___Nested_For_Loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested For Loop

            for (int i = 0; i < 5; i++) 
            { 
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Nested For Loop");
                }

                Console.WriteLine("\t");
                Console.WriteLine("Inner For Loop Ends");
                Console.WriteLine("\t");
            }

            Console.ReadLine();


        }
    }
}
