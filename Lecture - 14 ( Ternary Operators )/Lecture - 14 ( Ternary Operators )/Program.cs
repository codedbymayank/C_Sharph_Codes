using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture___14___Ternary_Operators__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = (3 > 4 ? 3 : 0);
            Console.WriteLine(val);

            bool bval = (true==true?true:false);
            Console.WriteLine(bval);


            Console.ReadLine();

        }
    }
}
