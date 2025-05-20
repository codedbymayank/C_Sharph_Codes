using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Indexers__
{
    public class A
    {
        int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10};

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a[9] = 100;
            Console.WriteLine(a[9]);
        }
    }
}
