using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int category = 0;
            int speed;
            WriteLine("Enter the wind Speed: ");
            speed = int.Parse(ReadLine());
            if (speed >= 157)
                category = 5;
            else
                if (speed >= 130)
                category = 4;
            else
                if (speed >= 111)
                category = 3;
            else
                if (speed >= 96)
                category = 2;
            else
                if (speed >= 74)
                category = 1;
            else
                WriteLine("This is not a hurrican");
            if (category > 0)
                WriteLine("This is a category {0} hurrican", category);
            
            
            
      
        }
    }
}
