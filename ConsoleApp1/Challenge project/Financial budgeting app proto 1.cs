using System;
using static System.Console;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double balance,monthlyExpensives,remainingBalance;
            balance = CalculateMonthlyIncome();
            monthlyExpensives = CalculateCost();
            remainingBalance =CalculateMontlyRemaingMoney(balance, monthlyExpensives);
           
        }
       private static void DisplayWelcome()
        {
            WriteLine("Welcome to Financial Budgeting for the month");
            WriteLine("You will enter answer questions about your income first");
            WriteLine("Then you will provided your monthly expenses and what you want to buy");

        }
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

        }

        public static double CalculateCost()
        {
            char stop = 'N';
            int listAmount = 0;
            double itemCost;
            double totalCost = 0;
            WriteLine("How many things are you currently paying for or want to buy?");
            listAmount = int.Parse(ReadLine());
            while (stop != 'Y')
            {
                string[] itemsName = new string[listAmount];
                double[] itemsCost = new double[listAmount];

                for (int i = 0; i < listAmount; i++)
                {
                    Write("Please enter the name of item: ");
                    itemsName[i] = Convert.ToString(ReadLine());
                }

                for (int j = 0; j < listAmount; j++)
                {
                    Write("Please enter how much does {0} cost: ", itemsName[j]);
                    itemsCost[j] = Convert.ToDouble(ReadLine());
                }
                for (int k = 0; k < listAmount; k++)
                {
                    WriteLine("[{0}] cost [{1}]", itemsName[k], itemsCost[k]);
                }
                foreach (double cost in itemsCost)
                {
                    itemCost = cost;
                    totalCost = totalCost + itemCost;
                }
                WriteLine("Is this all correct? If so enter Y if not enter N");
                stop = Convert.ToChar(ReadLine());
            }
            return totalCost;
        }
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
        }
        private static string DisplayOverCostItem()
        {
            
        }
    }

        
}
