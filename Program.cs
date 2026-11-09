using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleshi
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("------- TERMINAL -------");

            Console.WriteLine("      Enter name:"       );
            string User = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("------------------------");

            Console.WriteLine("      Enter age:        ");

            string age = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Hey, " + User + " you are " + age + " years old!");
        }
    }
}
