using System;
using static System.Console;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
            double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00,
         5.25, 5.75, 6.10, 10.00};
            string code;
            int index;
            WriteLine("Please enter your zip code: ");
            code = ReadLine();
            index = Array.BinarySearch(zips, code);
            if (index < 0)
                WriteLine("Sorry - no delivery to {0}", code);
            else
                WriteLine("Delivery to {0} ok. Delivery charge is {1}", code, prices[index].ToString("C"));
        }
    }
}
