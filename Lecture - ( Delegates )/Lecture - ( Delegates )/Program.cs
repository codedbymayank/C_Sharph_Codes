using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void GreetUser(string name);
namespace Lecture_____Delegates__
{
    
    internal class Program
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name + "!");
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            GreetUser obj = new GreetUser(program.SayHello);
            //Multicasting
            obj += program.SayGoodbye;
            obj.Invoke("Mayank");

        }
    }
}
