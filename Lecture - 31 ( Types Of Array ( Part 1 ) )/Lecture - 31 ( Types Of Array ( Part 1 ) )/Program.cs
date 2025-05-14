using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___31___Types_Of_Array___Part_1____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            int[] newarray = { 1, 2, 3 };

            Console.WriteLine(newarray[2]);

            //Multidimensional array
            int[,] marray = new int[2, 3] { {1, 2, 3}, {2, 3, 4} };

            //For multidimensional 2nd type
            int[2,3] newarray = { { 1, 2, 3}, {3, 4, 5} };

            //Accessing multidimensional elements
            Console.WriteLine(marray[0,1]);

            //Length of dimension :- row
            Console.WriteLine(marray.GetLength(0));
            //Column
            Console.WriteLine(marray.GetLength(1));
            //Rank :- return no of dimension
            Console.WriteLine(marray.Rank);

            Console.WriteLine("\t");


            //Accessing all elements of multi dimension array
            Console.WriteLine("Access multidimension array");
            Console.WriteLine("\t");
            for (int i = 0; i < marray.GetLength(0); i++)
            {
                for (int j = 0; j < marray.GetLength(1); j++)
                {
                    Console.Write(marray[i,j] + " ");
                }   
                Console.WriteLine();
            }

            Console.WriteLine("Accessing multidimensional array ends");


            Console.ReadLine();



        }
    }
}
