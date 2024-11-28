using System;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // does not work
            int check;
            string account;
            WriteLine("Enter the account number: ");
            account = ReadLine();
            string checkNum1 = account.Substring(0, 3);
            string checkNum2 = account.Substring(3, 1);
            check = (int.Parse(checkNum1) % 7);
            //WriteLine(check);
            //WriteLine(int.Parse(checkNum2));
            if (check == int.Parse(checkNum2))
                WriteLine("The account number is vaild");
            else
                WriteLine("Invaild");
        }
    }
}
