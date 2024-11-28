using System;
using static System.Console;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Raise = 0.04;
            double salary1 = 25000, salary2 = 38000, salary3 = 51000;
            WriteLine("What is the salary of the First employee? :");
            salary1 = double.Parse(ReadLine());
            WriteLine("What is the salary of the Second employee? :");
            salary2 = double.Parse(ReadLine());
            WriteLine("What is the salary of the Third employee? : ");
            salary3 = double.Parse(ReadLine());
            WriteLine("Next year's salary for the first employee will be {0}", (salary1 + salary1 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Next year's salary for the second employee will be {0}", (salary2 + salary2 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Next year's salary for the third employee will be {0}", (salary3 + salary3 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }

        
    }
}
