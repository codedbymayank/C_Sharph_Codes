using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___20___Nested_Switch_Case__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested Switch :- One switch case inside another switch case

            int x = 199;
            int y = 210;

            switch (x) 
            {
                case 199:
                    
                    switch (y) 
                    {
                        case 210:
                            Console.WriteLine("Nested Switch");
                            break;
                        case 220:
                            Console.WriteLine("Not Matched");
                            break;
                    }

                    Console.WriteLine("Condition True");
                    break;
            }

            Console.ReadLine();
        }
    }
}
