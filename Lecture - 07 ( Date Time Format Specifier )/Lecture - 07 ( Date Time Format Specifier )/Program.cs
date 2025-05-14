using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___07___Date_Time_Format_Specifier__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime is built in class , which is present in .net framework 
            DateTime dt = DateTime.Now;

            //d , D , f :- Date Time Format Specifiers
            // small letters is for short and big letters is for long 
            //{} :- is a placeholder in which value of dt will add or show
            Console.WriteLine("{0:d}",dt);

            Console.WriteLine("{0:D}",dt);

            Console.WriteLine("{0:f}",dt);

            Console.WriteLine("{0:d} {1:D}", dt , dt);

            // Customise format for DateTime Format
            Console.WriteLine("{0:hh:mm:ss tt}",dt);

            Console.ReadLine();


        }
    }
}
