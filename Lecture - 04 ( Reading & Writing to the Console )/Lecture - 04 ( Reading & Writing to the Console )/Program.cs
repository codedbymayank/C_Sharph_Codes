using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___04___Reading___Writing_to_the_Console__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Output
            //Console.WriteLine("Enter your name");
            //For Input
            //string name = Console.ReadLine();

            // First way using concatenation
            //Console.WriteLine("Your name is : " + name);

            //Second way using Placeholder where name value will replace with {0}
            //Console.WriteLine("Your name is : {0}" , name);

            Console.WriteLine("Print Integer");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number is : {0}",number);


            Console.ReadLine();

        }
    }
}
