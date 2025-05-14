using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___32___Types_Of_Array___Part_2____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiarray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Accessing multi dimension using foreach loop
            //Rectangular array
            foreach(var item in multiarray)
            {
                Console.WriteLine(item);
            }


            //Jagged Array
            int[][] myarray = new int[3][];
            myarray[0] = new[] { 1, 2 };
            myarray[1] = new[] { 3 , 4 };
            myarray[2] = new[] { 5, 6 };


           Console.ReadLine();

        }
    }
}
