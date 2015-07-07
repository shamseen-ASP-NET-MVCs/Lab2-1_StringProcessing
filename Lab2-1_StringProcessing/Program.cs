using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_StringProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu bar: Debug > Lab2-1_StringProcessing > Debug > Command Line Arguments
            //wrote in "O brother where art thou" ==> this will be Main's parameters.
            Console.WriteLine("\n\n-----ORIGNAL COMMAND LINE ARGUMENTS-----");
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);

            //reversing order
            Console.WriteLine("\n\n-----REVERSING ORDER-----");
            for (int i = args.Length - 1; i > 0; i-- )
                Console.WriteLine(args[i]);

            //print out every word in all uppercase
            Console.WriteLine("\n\n-----ALL UPPERCASE, IN ORDER-----");
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine( args[i].ToUpper() );


            //concatentate every string on command line as one string, sep'd by commas
            Console.WriteLine("\n\n-----CONCATENATION + SEPARATED BY COMMAS----");

            String wholeLine = args[0]; //starting with first word

            for (int i = 1; i < args.Length; i++)
                wholeLine = wholeLine + ", " + args[i];

            Console.WriteLine(wholeLine);
        }
    }
}
