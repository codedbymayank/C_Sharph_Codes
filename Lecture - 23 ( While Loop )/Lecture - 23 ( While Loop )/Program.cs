using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___23___While_Loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loop

            int u = 1;
            while (u < 12)
            {
                Console.WriteLine("Print Karte Ja");
                u++;
            }
            if (u == 12)
            {
                Console.WriteLine("Print rok de be yahi pe");
            }
            else
            {
                Console.WriteLine("Mat rok");
            }

            Console.ReadLine();
        }
    }
}
