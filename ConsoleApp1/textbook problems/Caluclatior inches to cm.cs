using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CENTIMETERS_PER_INCH = 2.54;
            double inches = 3;
            WriteLine("How many inches: ");
            inches = double.Parse(ReadLine());
            WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH);


            
        }
    
    }
}
