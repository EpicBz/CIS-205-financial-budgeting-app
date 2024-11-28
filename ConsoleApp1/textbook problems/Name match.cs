using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bossName;
            bool areNamesTheSame = true;
            Console.Write("Enter your name >>");
            name = Console.ReadLine();
            Console.Write("Hello {0}! Enter the name of your boss >>", name);
            bossName = Console.ReadLine();
            _=areNamesTheSame == String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);
        }
    }
}
