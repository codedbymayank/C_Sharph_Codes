using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___25___Diff_between_For_And_While_Loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Loop

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For Loop Ends");
            Console.WriteLine("\t");
            //While Loop

            int j = 9;
            while (j > 0) 
            {
                Console.WriteLine(j);
                j--;
            }

            Console.WriteLine("While Loop Ends");

            Console.ReadLine();
        }
    }
}
