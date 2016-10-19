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
        static double f01(string[] args)
        {
            return 1;
        }
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
                t2 = 1;
                Console.WriteLine("----------------------------");
                //Console.WriteLine("Loop iteration: {0}", loopIT);
                Console.Write("Input <empty to exit>: ");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "") { quit = true; break; }

                Console.WriteLine("Raw input: {0}", input);

                input = input.Replace(" ", "");
                input = input.Replace("+-", "-");
                input = input.Replace("--", "+");
                inputFormated = input;
                inputFormated = inputFormated.Replace("-"," - ");
                inputFormated = inputFormated.Replace("+", " + ");
                inputFormated = inputFormated.Replace("*", " * ");
                inputFormated = inputFormated.Replace("*  - ", "* -");
                if (input.StartsWith("-"))
                {
                    input = input.TrimStart('-');
                    inputFormated = inputFormated.TrimStart(' ').TrimStart('-').TrimStart(' ');
                    inputFormated =  '-' + inputFormated;
                    input = input.Replace("-", "+-");
                    input = "-" + input;
                } else
                {
                    input = input.Replace("-", "+-");
                }
                input = input.Replace("*+", "*");



                String[] substringsAdd = input.Split('+');
                String[] substringsMultiply = input.Split('*');
                //String[] substringsMultiply2 = new String[31];
                //Console.WriteLine("Length: " + substringsAdd.GetLength(0));

                //foreach (var substring in substringsAdd)
                    //Console.WriteLine("Add: : " + substring);
                Console.WriteLine("");
                //foreach (var substring in substringsMultiply)
                //Console.WriteLine("Mpl: : " + substring);
                Console.WriteLine("Formated input: {0}", input);
                Console.WriteLine("");
                if (substringsAdd.GetLength(0) > 0)
                for (int i = 0; i < substringsAdd.GetLength(0); i++)
                {
                    String[]  substringsMultiply2 = substringsAdd[i].Split('*');
                    Console.Write("Add: " + i + " :" + substringsAdd[i] + ", ");
                    foreach (var substring in substringsMultiply2)
                    {
                        if (substring != "")
                        t2 *= Convert.ToDouble(substring);
                    }
                    //Console.WriteLine("Mpl: : " + substring);
                    substringsAdd[i] = t2.ToString();
                    t2 = 1;
                    Console.Write(substringsAdd[i] + "\n");
                }
                Console.WriteLine("");
                //foreach (var substring in substringsMultiply)
                //Console.WriteLine("Mpl: : " + substring);
                /*if (substringsMultiply.GetLength(0) > 1)
                {
                    for (int i = 0; i < substringsAdd.GetLength(0); i++)
                    {
                        substringsMultiply2 = substringsAdd[i].Split('*');

                    }
                    foreach (var substring in substringsMultiply2)
                        //t2 *= Convert.ToDouble(substring);
                        Console.WriteLine("Mpl: : " + substring);
                }*/

                /*if (substringsMultiply.GetLength(0) > 1)
                {
                    try
                    {
                        foreach (var substring in substringsMultiply)
                            t2 *= Convert.ToDouble(substring);
                        Console.WriteLine(inputFormated + " = " + t2);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid expression or...?");
                        Console.WriteLine(inputFormated);
                        Console.WriteLine("");
                    }
                }*/
                if (substringsAdd.GetLength(0) > 0)
                {
                    try
                    {
                        foreach (var substring in substringsAdd)
                            t1 += Convert.ToDouble(substring);
                        Console.WriteLine(inputFormated + " = " + t1);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid expression or...?");
                        Console.WriteLine(inputFormated);
                        Console.WriteLine("");
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
