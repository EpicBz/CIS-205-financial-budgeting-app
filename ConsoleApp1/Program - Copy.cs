using System;
using static System.Console;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    class FinancialBudgetingApp
    {
        public static void Main(string[] args)
        {
           
            int number = 3;
            string[] list = new string[number];
            double[] list1 = new double[number];
            double balance, monthlyExpensives, remainingBalance;
            DisplayWelcome();
            balance = CalculateMonthlyIncome();
            string[] itemName = DelcareItemName(list);
            double[] itemCost = DelcareItemCost(list1);
            for (int i = 0; i < itemCost.Length; i++)
            {
                WriteLine(itemCost[i]);
            }
            WriteLine(balance);
            monthlyExpensives = CalculateMonthlyExpensives(list1);
            WriteLine(monthlyExpensives);
            remainingBalance = CalculateMontlyRemaingMoney(balance, monthlyExpensives);
            WriteLine(remainingBalance);

        }
        private static void DisplayWelcome()
        {
            WriteLine("Welcome to Financial Budgeting for the month");
            WriteLine("You will enter answer questions about your income first");
            WriteLine("Then you will provided your monthly expenses and what you want to buy");

        } //Instructions

        private static double CalculateMonthlyIncome()
        {
            int hr, rate;
            double balance = 0;
            double employeeType = 0;
            while (employeeType != 1 && employeeType != 2)
            {
                WriteLine("Please enter if your a what kind of employee you are? Enter 1 for hourly or 2 for salary");
                employeeType = double.Parse(ReadLine());
                if (employeeType == 1)
                {
                    WriteLine("How much are you paid?");
                    rate = int.Parse(ReadLine());
                    WriteLine("How many hours do you work in a week?");
                    hr = int.Parse(ReadLine());
                    if (hr > 40)
                        balance = ((rate * 40) + (rate * (hr - 40))) * 4;
                    else
                        balance = rate * hr;
                }
                if (employeeType == 2)
                {
                    WriteLine("What is your yearly salary amount?");
                    rate = int.Parse(ReadLine());
                    balance = rate / 12;
                }
                if (employeeType >= 3)
                    WriteLine("Error! Type of employee was entered incorrectly");
            }
            return balance;

        }//Takes in user inputs to calculate their monthly income 
        public static double[] DelcareItemCost(double[] list1)
        {

            double[] item = new double[list1.Length];

            for (int i = 0; i < item.Length; i++)
            {
                Write("Please enter the cost of item: ");
                item[i] = Convert.ToDouble(ReadLine());
            }

         
            return item;
        } //Creates an array for items cost
        static double CalculateMonthlyExpensives(double[] list1)
        {
            double itemCost;
            double totalCost = 0;
            foreach (double cost in list1)
            {
                itemCost = cost;
                totalCost = totalCost + itemCost;
            }
            return totalCost;
        }//Calculates the users total expenises by adding each item in a itemcost list. Result is incorrect
        public static string[] DelcareItemName(string[] list)
        {
            string[] item = new string[list.Length];

            for (int i = 0; i < item.Length; i++)
            {
                Write("Please enter the name of item: ");
                item[i] = Convert.ToString(ReadLine());
            }

            return item;
        } //Creates an array for items name

        private static double CalculateMontlyRemaingMoney(double balance, double expensives)
        {
            double remainBalance, fed, sst, retirment;
            const double federalTax = 0.18;
            const double socialSecurityTax = 0.06;
            const double retirementContribution = 0.1;
            fed = balance * federalTax;
            sst = balance * socialSecurityTax;
            retirment = balance * retirementContribution;
            remainBalance = balance - (fed + sst + retirment);
            remainBalance = remainBalance - expensives;

            return remainBalance;
        }//Calculates the remaing amount of money users has after taxes and their expenses for the month
        //private static string DisplayOverCostItem()
        //{

        //}
    }


}