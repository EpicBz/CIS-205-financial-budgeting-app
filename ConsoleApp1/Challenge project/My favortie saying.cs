using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select a number from 1 to 3. A great star wars qoute, there is.  :");
            string answer = Console.ReadLine();
            int num1 = Convert.ToInt32(answer);
            int ch1 = Convert.ToInt32("1");
            int ch2 = Convert.ToInt32("2");
            int ch3 = Convert.ToInt32("3");
            if (num1 == ch1)
            {
                Console.WriteLine("May the force be with you");
            }
            else
            if (num1 == ch2)
            {
                Console.WriteLine("May the");
                Console.WriteLine("Force be");
                Console.WriteLine("With you");
            }
            else
            if (num1 == ch3)
            {
                Console.WriteLine("May");
                Console.WriteLine("The");
                Console.WriteLine("Force");
                Console.WriteLine("Be");
                Console.WriteLine("With");
                Console.WriteLine("You");
            }
            else
            {
                Console.WriteLine("        xx");
                Console.WriteLine("       x  x"); 
                Console.WriteLine("      x    x");
                Console.WriteLine("     x      x");
                Console.WriteLine("    x    |   x");
                Console.WriteLine("   x     |    x");
                Console.WriteLine("  x      |     x");
                Console.WriteLine("  x            x");
                Console.WriteLine("   x          x");
                Console.WriteLine("    x    *   x");
                Console.WriteLine("     x      x");
                Console.WriteLine("      x    x");
                Console.WriteLine("       x  x");
                Console.WriteLine("        xx");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Hmm, Lack of faith you have. Directions you must follow.");
            }
        }
    }
}
