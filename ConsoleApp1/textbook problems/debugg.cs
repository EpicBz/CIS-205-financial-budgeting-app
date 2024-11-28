using System;
using static System.Console;

namespace ConsoleApp1
{
    class debugg
    {
        static void Main(string[] args)
        {
            string name;
            string firstString, secondSting;
            int first, second, product;
            WriteLine("Enter your name >>");
            name = ReadLine();
            Write("Hello, {0}! Enter an integer >> ", name);
            firstString = ReadLine();
            first = Convert.ToInt32(firstString);
            Write("Enter another integer >> ");
            secondSting = ReadLine();
            second = Convert.ToInt32(secondSting);
            product = first * second;
            WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
           name, first, second, product);

            const string PASS1 = "home";
            const string PASS2 = "lady";
            const string PASS3 = "mouse";
            string password;

            Write("Please enter your password ");
            password = ReadLine();
            while (password != PASS1 || password != PASS2 || password != PASS3)
            {
                if (password == PASS1 || password == PASS2 || password == PASS3)
                    WriteLine("Valid password");
                else
                    WriteLine("Invalid password. Please enter again. ");
                password = ReadLine();

            }
        }
    }
}
