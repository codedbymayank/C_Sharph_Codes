using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Properties__
{
    class A
    {
        public int id;
        public string name;

        public string p1
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
           
            obj.name = "New Name";
            Console.WriteLine(obj.p1);

            Console.ReadLine();

        }
    }
}
