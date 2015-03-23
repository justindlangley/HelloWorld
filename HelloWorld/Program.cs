
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print string "Hello" and print arguments "Justin" and "Langley"
            //Console.WriteLine("Hello " + args [0] + " " + args [1]);
            
            //Print arguments Justin and Langley with space in between
            //Console.WriteLine(args [0] + " " + args [1]);

            //Print arguments in order Langley and Justin with comma separator 
            Console.WriteLine(args [1] + ", " + args [0]);
   
            Console.ReadLine();

        }
    }
}
