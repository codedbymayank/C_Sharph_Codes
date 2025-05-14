using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___19___Switch_Case__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case :- To avoid multiple if statements

            int no = 192;

            switch (no) 
            {
                case 100:
                    Console.WriteLine("Isse bada hai no");
                    break;
                case 150:
                    Console.WriteLine("ye bhi chota hai no");
                    break;
                case 192:
                    Console.WriteLine("Mil Gaya");
                    break;
                case 1002:
                case 21002:
                case 2001:
                    Console.WriteLine("Out of Range");
                    break;

                default:
                    Console.WriteLine("Kuch nahi match hua");
                    break;
            }

            Console.ReadLine();


        }
    }
}
