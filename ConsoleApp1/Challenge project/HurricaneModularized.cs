using System;
using static System.Console;
namespace ConsoleApp1
{
    class HurricaneModularized
    {
        static void Main(string[] args)
        {
            double windspeed;
            double category;
            WriteLine("Please enter the currenet windspeed in mph: ");
            windspeed = double.Parse(ReadLine());
            category = GetCategory(windspeed);
            if (category > 0)
                WriteLine("This is a Category {0} hurrican with a wind speed of {1} mph", category, windspeed);
            else
                WriteLine("This is not a Hurrican");
        }
        private static double GetCategory(double speed)
        {
            double finalCategory,wind;
            double[] categoryLvl = { 1, 2, 3, 4, 5 };
            int index;
            if (speed >= 157)
                wind = 5;
            else
               if (speed >= 130)
                wind = 4;
            else
               if (speed >= 111)
                wind = 3;
            else
               if (speed >= 96)
                wind = 2;
            else
               if (speed >= 74)
                wind = 1;
            else
                wind = 0;
            index = Array.BinarySearch(categoryLvl, wind);
            if (index < 0)
                finalCategory = -1;
            else
                finalCategory = categoryLvl[index];
            return finalCategory;
        }
        
    }

}
