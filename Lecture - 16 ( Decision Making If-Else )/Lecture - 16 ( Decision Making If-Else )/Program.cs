using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___16___Decision_Making_If_Else__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decision Making :- If-else

            int x = 199;
            int y = 213;

            if (x >= 221)
            {
                Console.WriteLine("It is true");
            }
            else 
            {
                Console.WriteLine("It is False");
            }


            string name = "Tukonmeikhamakha";
            string pass = "accha";
            
            //Logical And in If-Else
            if(name== "Tukonmeikhamakha" && pass == "accha")
            {
                Console.WriteLine("Permission Granted");
            }
            else
            {
                Console.WriteLine("Permission Denied");
            }

            Console.ReadLine();
        }
    }
}
