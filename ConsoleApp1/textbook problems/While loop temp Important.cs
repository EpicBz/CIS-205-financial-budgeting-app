using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that ask for temp and has a sential value of 999 and a range of -20 through 130 with an error message invaild number. displays all numbers entered and average

            int count = 0;
            double tempTemp;
            double totalTemp = 0;
            while (999 != (tempTemp = double.Parse(ReadLine())))
                if (tempTemp > -20 && tempTemp < 130)
                {
                    totalTemp += tempTemp; count++;
                }
                else
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
            WriteLine($"{count} {totalTemp / count}");
        }
    }
}
    
    
