using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Partial_Classess__
{
    public partial class A
    {
        public A()
        {
            this.id = 10;
            this.name = "Rudra";
            Console.WriteLine("My Id is : " + id);
        }

        public void M1()
        {
            Console.WriteLine("Method1");
        }
    }
    
}
