using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_____Encapsultaion__
{

    class Encap
    {
        private int id;
        private string name;    

        public int M1
        {
            set { id = value; }
            get { return id; }

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Encap encap = new Encap();
            encap.M1 = 199;
            Console.WriteLine(encap.M1);

            Console.ReadLine();


        }
    }
}
