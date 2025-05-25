using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Value___Refrence_Type__
{
    class Refclass
    {
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            //Value type
            int b = a;

            //Refrence Type
            Refclass obj = new Refclass();
            obj.name = "Rudra";
            Refclass obj2 = obj;
            obj2.name = "Omkara";

            Console.WriteLine("After Refrence Type");
            Console.WriteLine(obj.name);
            Console.WriteLine(obj2.name);
            Console.ReadLine();


        }
    }
}
