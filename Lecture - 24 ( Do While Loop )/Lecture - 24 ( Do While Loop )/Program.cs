using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___24___Do_While_Loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 100;
            do
            {
                Console.WriteLine("First Do-While Loop");
                s++;
            }
            while (s < 10);

            Console.ReadLine();
            
        }
    }
}
