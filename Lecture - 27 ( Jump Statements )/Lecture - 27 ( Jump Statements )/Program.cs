using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___27___Jump_Statements__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jump Statement :- break , continue , goto , return 

            // Break keyword
            for (int i = 0; i < 4; i++)
            {
                if (i == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\t");
            Console.WriteLine("Break Ends");
            Console.WriteLine("\t");


            // Continue Keyword

            for(int j = 0; j < 6; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }

            Console.WriteLine("\t");
            Console.WriteLine("Continue Ends");
            Console.WriteLine("\t");

            //Goto Statements :- It work with label

            for (int k = 0; k < 6; k++)
            {
                if (k == 5)
                {
                    //here instead of stop it can be any word like variable
                    goto stop;
                }
                else
                {
                    Console.WriteLine(k);
                }
            }
            
            stop:
            Console.WriteLine("Goto Statement");


            Console.ReadLine();

        }
    }
}
