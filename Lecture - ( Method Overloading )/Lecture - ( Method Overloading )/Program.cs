using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Method_Overloading__
{
    public class Program
    {

        public void Method1(string name)
        {
            Console.WriteLine("My name is " + " " + name);
        }

        public void Method1(int num)
        {
            Console.WriteLine("Method " + " " + num + " is calling");
        }

        public void RefMethod(ref string name)
        {
            name = "Hello";
            
        }
        public void OutMethod(out int no)
        {
            no = 100;

        }

        public void OptionalPara(string name = "Roy")
        {
            Console.WriteLine("My name is : " + name);
        }

        public void DynamicPara(dynamic name)
        {
            name += " and my surname is : Oberoi";
        }
        public void NumsPara(params int[] nums)
        {
            for(int i = 0 ; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            //Method Overloading
            obj.Method1("Mayank");
            obj.Method1(2);
           

            //Method Parameter
            
            // Named :- When we did not know the position of parameter
            
            // Ref :- When we want some updates in our value 
            string name = "Mayank";
            Console.WriteLine("Before ref : " + name);
            obj.RefMethod(ref name);
            Console.WriteLine("After ref : "+ name);
            Console.ReadLine();

            // Out :- When we want some updates in our value but It should not compulsory to intialize
            int no ;
            
            obj.OutMethod(out no);
            Console.WriteLine("After out : " + no);
            Console.ReadLine();

            //Optional Parameter :- Passing a para is not compulsory 
            obj.OptionalPara("Mayank");
            obj.OptionalPara();

            //Dynamic Parameter :- Check types during run time , instead of compile time 
            obj.DynamicPara("Shivayee");

            //Params Keyword :- When u didn't know the no of arguments u are going to passed
            obj.NumsPara(10, 20, 30, 100, 17, 18, 10, 1);

        }
    }
}
