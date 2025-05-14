using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___29___Arrays_in_C_Sharph__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaring a array 

            //1st Way 
            // new keyword :- Basically it asign memory
            int[] newarray = new int[5];

            //Asssigning values using index number
            newarray[0] = 1;
            newarray[1] = 2;
            newarray[2] = 3;

            Console.WriteLine(newarray[2]);
            Console.WriteLine(newarray[3]);

            Console.WriteLine("\t");

            //2nd Way 
            string[] newarray2 = new string[] {"name1","name2","name3"};

            //3rd Way
            string[] newarray3 = {"myname1","myname2","myname3"};

            Console.WriteLine(newarray3[0]);
            Console.WriteLine(newarray3[1]);
            Console.WriteLine(newarray3[2]);

            //Getting size of an array
            Console.WriteLine("Length of an array is : " + newarray3.Length);


            Console.ReadLine();
        }
    }
}
