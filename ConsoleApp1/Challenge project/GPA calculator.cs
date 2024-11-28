using System;
using static System.Console;
namespace ConsoleApp1
{
    class GPACalulator
    {
        static void Main(string[] args)
        {
            const char A = 'A';
            const char B = 'B';
            const char C = 'C';
            const char D = 'D';
            const char F = 'F';
            const char quit = 'N';
            char grade, resume;
            double totalHours = 0;
            double gradePoints = 0;
            double totalQuility = 0;
            double quility = 0;
            double hours,GPA;
            WriteLine("You will be prompted to input number of hours and the letter grade earned for the course");
            WriteLine("Your GPA will be is calculated and displayed when you are done adding your courses");
            WriteLine("");
            WriteLine("Press 'Y' to Start");
            resume = Convert.ToChar(ReadLine());
            while(resume != quit)
            {
                WriteLine("");
                WriteLine("Please enter course grade (A,B,C,D, or F) : ");
                grade = Convert.ToChar(ReadLine());
                WriteLine("Please enter the number of hours earned for the course:");
                hours = Convert.ToDouble(ReadLine());
                totalHours = totalHours + hours;
                if (grade == A)
                    gradePoints =  4;                   
                    quility = gradePoints * hours;
                if(grade == B)
                    gradePoints = 3;
                    quility = gradePoints * hours;
                if (grade == C)
                    gradePoints = 2;
                    quility = gradePoints * hours;
                if (grade == D)
                    gradePoints = 1;                   
                    quility = gradePoints * hours;
                if (grade == F)
                    gradePoints =  0;                   
                    quility = gradePoints * hours;                   
                WriteLine("");
                totalQuility = totalQuility + quility;
                WriteLine("");
                WriteLine("Would you like to enter another course?");
                WriteLine("Please enter 'Y' for Yes or enter 'N' for NO");
                resume = Convert.ToChar(ReadLine());
            }
            GPA = totalQuility / totalHours;
            WriteLine("");
            WriteLine("**************************************");
            WriteLine("      Grade Point Average App");
            WriteLine("Number of hours earned:  {0}", totalHours);
            WriteLine("GPA : {0}", GPA);
            WriteLine("**************************************");
        }
    }
}
