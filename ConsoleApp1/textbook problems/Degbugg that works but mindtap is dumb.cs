﻿using System;
using static System.Console;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChili, wantCheese;
            double price = 1;

            Write("Do you want chili on your dog? ");
            wantChili = ReadLine();
            Write("Do you want cheese on your dog? ");
            wantCheese = ReadLine();
            if (wantChili == "Y")
            
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
            if (wantChili == "N")
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHEESE_PRICE;
            if (wantChili == "Y")
                if (wantCheese == "N")
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            if (wantChili == "N")
                if (wantCheese == "N")
                    price = BASIC_DOG_PRICE;

            WriteLine("Your total is {0}", price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            
        }
    }
}
