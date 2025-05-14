using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___22___For_Loop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            string s = "tukonmeikhamakha";
            for (int i = 0; i < s.Length; i++) 
            {
                Console.WriteLine(s[i]);
            }

            for(int j = 0; j < 4 ; j++)
            {
                Console.WriteLine("Tu Ja Bhad Mei");
            }

            Console.WriteLine("\t");

            Console.WriteLine("Tata Bye Bye");
           
            Console.ReadLine();
        }
    }
}
