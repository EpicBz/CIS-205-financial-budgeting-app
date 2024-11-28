using System;
using static System.Console;

namespace ConsoleApp1
{
    class Twitter
    {
        static void Main(string[] args)
        {
            String message;
            int howlong = 1;
            WriteLine("Enter your twitter message here: ");
            message = ReadLine();
            howlong = message.Length;
            if (howlong > 140)
                WriteLine("This message is too long");
            else
                WriteLine("The message is okay");



        }
    }
}
