using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
            WriteLine("Please enter your zip code: ");
            string code;
            int index;
            code = ReadLine();
            index = Array.BinarySearch(zips, code);
            if (index < 0)
                WriteLine("Sorry no deliver to {0}", code);
            else
                WriteLine("Deliver to {0} ok", code);

        }
    }
}
