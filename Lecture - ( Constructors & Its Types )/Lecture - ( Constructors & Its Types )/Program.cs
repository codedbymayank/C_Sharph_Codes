using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Constructors___Its_Types__
{
    //For Default Constructor
    class DefaultConstructorclass
    {
        int id;
        public DefaultConstructorclass()
        {
            this.id = 100;
            Console.WriteLine("Default Constructor");
        }

        public string M1()
        {
            //For Default Constructor
            DefaultConstructorclass obj = new DefaultConstructorclass();
            return "Returning result from method which is inside default constructor : " + id;
            //Or
            //return "Returning result from method which is inside default constructor : " + obj.id;

        }

    }

    //For Parameterized Constructor
    class ParameterizedConstructor
    {
        string name;
        public ParameterizedConstructor(string fullname)
        {
            this.name = fullname;
        }

        public string M2()
        {
           return "My name is : " + name;
        }
    }

    //For Copy Constructor

    class CopyConstructor
    {
        int id;
        string firstname;
        int copyid;
        string copyname;

        public CopyConstructor(CopyConstructor cp)
        {
            copyid = cp.id;
            copyname = cp.firstname;
        }

        public CopyConstructor(int _id , string _name)
        {
            this.id = _id;
            this.firstname = _name;
        }

        public string ForNormalConstructor()
        {
            return "My id is : " + id + " and My name is : " + firstname;
        }

        public string ForCopyConstructor()
        {
            return "My id is : " + copyid + " and My name is : " + copyname;
        }
    }


    //For Private Constructor

    class PrivateConstructor
    {
        string myname;
        private PrivateConstructor(string _myname)
        {
            this.myname = _myname;
        }

        public void PrivateConstructorMethod()
        {
            PrivateConstructor obj = new PrivateConstructor("Rudra");
            Console.WriteLine("Calling from Private Constuctor");
        }
    }

    //For Static Constructor
    class StaticConstructor
    {
        int groupno;
        static StaticConstructor()
        {
            Console.WriteLine("Printing from Static Constructor");
        }

        public StaticConstructor(int _groupno)
        {
            this.groupno = _groupno; 
        }

        public string StaticConstructorMethod()
        {
            return "My groupno is : " + groupno;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //For Default Constructor
            DefaultConstructorclass obs = new DefaultConstructorclass();
            Console.WriteLine(obs.M1());

            //For Parameterized Constructor

            ParameterizedConstructor obj = new ParameterizedConstructor("Mayank Pal");
            Console.WriteLine(obj.M2());

            //For Copy Constructor
            CopyConstructor finalobj = new CopyConstructor(28, "Omakara Oberoi");
            CopyConstructor cpobj = new CopyConstructor(finalobj);

            Console.WriteLine(finalobj.ForNormalConstructor());
            Console.WriteLine(cpobj.ForCopyConstructor());

            //For Private Constructor
            //PrivateConstructor ob = new PrivateConstructor(); ----> This will give an error becuase our constructor is private 

            //For Static Constructor
            StaticConstructor sco = new StaticConstructor(291);
            Console.WriteLine(sco.StaticConstructorMethod());

            Console.ReadLine();
        }
    }
}
