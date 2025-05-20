using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Array_List__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(321);
            obj.Add(100);
            obj.Add(00);
            obj.Add(40);
            obj.Add(90);

            foreach (var data in obj)
            {
                Console.WriteLine(data);
            }

            //It always give the no of elements it can store 
            Console.WriteLine("Capacity is : " + obj.Capacity);

            //It always give no of elements present in it
            Console.WriteLine("Count is : " + obj.Count);

            obj.Sort();

            Console.ReadLine();


        }
    }
}
