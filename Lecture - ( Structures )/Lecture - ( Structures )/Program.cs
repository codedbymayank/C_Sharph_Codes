using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Structures__
{
    //First Way to Initialize Struct using parameterized constructor
    struct ParaConstruct
    {
        public int id;
        public string name;
        public string description;

        public ParaConstruct(int _id , string _name , string _description)
        {
            this.id = _id;
            this.name = _name;
            this.description = _description;
        }
    }

    //Second way using new keyword 

    struct usingnewkeyword
    {
        public int rollno;
        public string stdname;

    }

    //Third way without using new keyword

    struct withoutnew
    {
        public string address;
    }

    //Immutable Structs :- means in which we can't change anything 

    struct ImmutableStructs
    {
        public readonly int dob;
        public readonly string govno;

        
        public ImmutableStructs(int _dob , string _govno)
        {
            this.dob = _dob;
            this.dob += 2;
            this.govno = _govno;
        }
       
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ParaConstruct obj = new ParaConstruct(10,"roy","SE");
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.description);

            usingnewkeyword obs = new usingnewkeyword();
            obs.rollno = 10;
            obs.stdname = "Shiavyee";
            Console.WriteLine(obs.rollno);
            Console.WriteLine(obs.stdname);

            withoutnew newobj;
            newobj.address = "NYC";
            Console.WriteLine(newobj.address);

            //Immutable Structs
            ImmutableStructs ims = new ImmutableStructs(10,"5432");
            Console.WriteLine(ims.dob);
            Console.WriteLine(ims.govno);



            Console.ReadLine();

        }
    }
}
