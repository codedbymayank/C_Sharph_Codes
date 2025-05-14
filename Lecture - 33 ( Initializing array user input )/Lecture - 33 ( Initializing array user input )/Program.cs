using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___33___Initializing_array_user_input__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of items");
            int num = int.Parse(Console.ReadLine());

            //Initializing a single dimension array
            int[] singarray = new int[num];

            //Taking values as a input from user 
            for (int i = 0; i < num; i++)
            {
                int value = int.Parse(Console.ReadLine());
                singarray[i] = value;
            }

            Console.WriteLine("Input Ends");
            Console.WriteLine("\t");

            //Printing Array
            for(int j = 0; j < singarray.Length; j++)
            {
                Console.WriteLine("Number " + j + " is " + singarray[j]);
            }


            Console.ReadLine();
        }
    }
}
