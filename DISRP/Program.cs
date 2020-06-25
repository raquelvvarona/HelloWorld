using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            // example 0 - first program
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            //Debug.WriteLine("Hello World!");

            // variables and native operations
            int x;
            int y;

            x = 3;
            y = 4;
            int sum = x + y;
            Console.Write("x + y is ");
            Console.WriteLine(sum);
        }
    }
}