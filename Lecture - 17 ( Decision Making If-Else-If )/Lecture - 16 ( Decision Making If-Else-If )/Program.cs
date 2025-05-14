using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___16___Decision_Making_If_Else_If__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decision Making :- If-Else-If
            int x = 212;
            if (x == 100)
            {
                Console.WriteLine("Mil Gaya");
            }
            else if (x >= 212)
            {
                Console.WriteLine("match hua hai");
            }
            else
            {
                Console.WriteLine("Kuch Nahi Mila");
            }

            Console.ReadLine();
        }
    }
}
