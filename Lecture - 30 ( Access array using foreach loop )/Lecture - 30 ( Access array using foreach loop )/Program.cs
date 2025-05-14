using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___30___Access_array_using_foreach_loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newarray = { 1, 2, 3, };

            //For Loop
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.WriteLine(newarray[i]);
            }

            Console.WriteLine("For Loop Ends");

            Console.WriteLine("\t");

            //For-each loop
            foreach(var item in newarray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("For Each Loop Ends");


            Console.ReadLine();
            
        }
    }
}
