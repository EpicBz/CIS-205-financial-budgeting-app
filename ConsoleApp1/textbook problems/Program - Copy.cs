using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gradePointAverage = 3.0;
            const double admissionTestAverageOne = 60;
            const double admissionTestAverageTwo = 80;
            double gradePoint, admissionTestScore;
            WriteLine("What is the student's GPA? ");
            gradePoint = double.Parse(ReadLine());
            WriteLine("What is the student's admission test score?");
            admissionTestScore = double.Parse(ReadLine());
            if (gradePoint >= gradePointAverage)
                if (admissionTestScore >= admissionTestAverageOne)
                    WriteLine("Accept");
            if (gradePoint >= gradePointAverage)
                if (admissionTestScore < admissionTestAverageOne)
                    WriteLine("Reject");
            if (gradePoint < gradePointAverage)
                if (admissionTestScore >= admissionTestAverageTwo)
                    WriteLine("Accept");
            
            if (gradePoint < gradePointAverage)
                if (admissionTestScore < admissionTestAverageTwo)
                    WriteLine("Reject");

        }
    }
}
