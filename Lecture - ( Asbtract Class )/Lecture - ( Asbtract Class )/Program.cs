using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Asbtract_Class__
{
    public abstract class Abstractclass
    {
        public int p1;

        public abstract int M1();

       

        
    }

    class AbstractInherit : Abstractclass
    {
        int id;
        public int p1
        {
            get { return 1; }
            set { id = 10; }
        }

        //OR for setting a value
        //public int p1 => 100;

        public override int M1()
        {
            return id;
        }

        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractInherit inherit = new AbstractInherit();    
            inherit.p1 = 1;
            Console.WriteLine(inherit.p1);
        }
    }
}
