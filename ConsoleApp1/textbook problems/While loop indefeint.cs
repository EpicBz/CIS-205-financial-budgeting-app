using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            const char quit = '!';
            WriteLine("Enter an uppercase Leter >>");
            letter = Convert.ToChar(ReadLine());
            while (letter != '!')
            {
                if (letter >= 'A' && letter <= 'Z')
                    WriteLine("OK");
                else
                    WriteLine("Sorry - that was not an uppercase letter");
                Write("Enter an uppercase letter or {0} to quit", quit);
                letter = Convert.ToChar(ReadLine());

            }
            WriteLine("Thank you");
            
        }
    }
}
