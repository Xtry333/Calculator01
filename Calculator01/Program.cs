using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            int loopIT = 0;
            string input = "";
            string inputFormated = "";

            double t1;
            double t2;

            while (!quit)
            {
                t1 = 0;
                t2 = 0;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Loop iteration: {0}", loopIT);
                Console.Write("Input <empty to exit>: ");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "") { quit = true; break; }
                
                input = input.Replace(" ", "");
                inputFormated = input;
                if (input.StartsWith("-"))
                {
                    input = input.TrimStart('-');
                    input = input.Replace("-", "+-");
                    input = "-" + input;
                } else
                {
                    input = input.Replace("-", "+-");
                }
                

                String[] substrings = input.Split('+');
                Console.WriteLine("Length: " + substrings.GetLength(0));

                foreach (var substring in substrings)
                    Console.WriteLine(":: " + substring);
                Console.WriteLine("");
                if (substrings.GetLength(0) > 1)
                {
                    try
                    {
                        foreach (var substring in substrings)
                            t1 += Convert.ToDouble(substring);
                        Console.WriteLine(inputFormated + " = " + t1);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid expression or...?");
                    }
                }
                loopIT++;
            }
            Console.Write("Exiting after {0} loop", loopIT);
            if (loopIT > 1) Console.Write("s"); Console.Write("...");
            Thread.Sleep(200);
        }
    }
}
