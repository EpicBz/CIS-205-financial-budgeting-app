using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
    //A program that accepts eight int values representing student test scores.

    //Display each of the values along with a message that indicates how far it is from the average.
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter the test scores.");
            var score = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                score.Add(int.Parse(ReadLine()));

            }
            var avg = score.Average();
            for (int i = 0; i < 8; i++)
            {
                WriteLine($"Test # {i}: {score[i]} From average: {score[i] - avg} ");
            }

        }
    }
}
