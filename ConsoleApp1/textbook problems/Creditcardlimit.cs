using System;
using static System.Console;

namespace ConsoleApp1
{
    class CheckCredit
    {
        static void Main(string[] args)
        {
            const double limit = 8000;
            double price = 1;
            WriteLine("What is the price of the item? ");
            price = Convert.ToDouble(ReadLine());

            if (price <= limit)

                WriteLine("Approved");
            else
                WriteLine("You have exceeded the credit limit");

        }




            
       
    }
}
