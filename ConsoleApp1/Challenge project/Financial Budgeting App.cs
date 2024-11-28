using System;
using static System.Console;
using System.Globalization;
using System.Linq;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Access both User and Calculator classes
            double income, cost, remainder;
            Calculator calc = new Calculator(); // delcares access to Calculator class
            User user = new User(); // delcares access to User class
            user.DisplayWelcome();
            income = user.CalculateMonthlyIncome();
            cost = calc.CalculateCost();
            remainder = calc.CalculateMontlyRemaingMoney(income, cost);
            // Write weather your at your budget/below/or above 
            if (remainder > 0)
            {
                WriteLine("Even with your most expensive item, you've saved {0} for this up coming month, with your monthly income being {1} and expensives being {2}", remainder.ToString("C", CultureInfo.GetCultureInfo("en-US")), income.ToString("C", CultureInfo.GetCultureInfo("en-US")), cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            }
            if (remainder < 0)
            {
                WriteLine("You May want to reconsidered your most expensive item for up coming this month as your over budget by {0} for the month. Your monthly income is this {1} and your expensives are this {2}", remainder.ToString("C", CultureInfo.GetCultureInfo("en-US")), income.ToString("C", CultureInfo.GetCultureInfo("en-US")), cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            }
            if (remainder == 0)
            {
                WriteLine("You are fully using your monthly income you have $0 remaining at the end of the month. Your monthly income is this {1} and your expensives are {2}", remainder.ToString("C", CultureInfo.GetCultureInfo("en-US")), income.ToString("C", CultureInfo.GetCultureInfo("en-US")), cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            }
            // Gives user more time to look at the results before Displaying the GoodBye message
            WriteLine("Please hit the Enter key when your ready to close app");
            ReadLine();
            Clear();
            user.DisplayGoodBye();
        }
        public class User
        {
            // Welcomes users to the program and provides instructions
            public void DisplayWelcome()
            {
                WriteLine("Welcome to Financial Budgeting for the month");
                WriteLine("You will enter answer questions about your income first");
                WriteLine("Then you will provided your monthly expenses and what you want to buy");


                Clear();
            }
            // calculates their monthly income/ gift money they've earned
            public double CalculateMonthlyIncome()
            {
                double hr, rate, fed, sst, retirment;
                const double federalTax = 0.18;
                const double socialSecurityTax = 0.06;
                const double retirementContribution = 0.1;
                double balance, remainBalance = 0;
                double employeeType = 0;
                while (employeeType != 1 && employeeType != 2 && employeeType != 3)
                {
                    // Finds out what kind of income you are or if you recieved gift money
                    WriteLine("Please enter if your a what kind of employee you are? Enter 1 for hourly, 2 for salary, of 3 for holiday money");
                    employeeType = double.Parse(ReadLine());
                    // Calculates monthly pay by ask for your hourly rate and most common hours worked
                    // then procees to remove taxes that are normally out of your income
                    if (employeeType == 1)
                    {
                        WriteLine("How much are you paid?");
                        rate = double.Parse(ReadLine());
                        WriteLine("How many hours do you work in a week?");
                        hr = double.Parse(ReadLine());
                        if (hr > 40)
                        {
                            balance = ((rate * 40) + (rate * (hr - 40))) * 4;
                            fed = balance * federalTax;
                            sst = balance * socialSecurityTax;
                            retirment = balance * retirementContribution;
                            remainBalance = balance - (fed + sst + retirment);
                        }
                        else
                        {
                            balance = rate * hr;
                            fed = balance * federalTax;
                            sst = balance * socialSecurityTax;
                            retirment = balance * retirementContribution;
                            remainBalance = balance - (fed + sst + retirment);
                        }
                    }
                    // Calculates monthly pay by asking for your yearly salairy
                    // then process to find monthly salairy and removes taxes
                    if (employeeType == 2)
                    {
                        WriteLine("What is your yearly salary amount?");
                        rate = double.Parse(ReadLine());
                        balance = rate / 12;
                        fed = balance * federalTax;
                        sst = balance * socialSecurityTax;
                        retirment = balance * retirementContribution;
                        remainBalance = balance - (fed + sst + retirment);
                    }
                    // Just asks for money amount as gift money does not last a week
                    if (employeeType == 3)
                    {
                        WriteLine("How much money do you have?");
                        remainBalance = double.Parse(ReadLine());
                    }
                    // error message when they input the wrong employee type
                    if (employeeType >= 4)
                        WriteLine("Error! Type of employee was entered incorrectly");

                }
                Clear();

                return remainBalance;

            }
            // Thanks the user and wishes them a good day
            public void DisplayGoodBye()
            {
                WriteLine("Thank you for using our services");
                WriteLine("Have a nice day, look forward to see you again");
            }
        }
        public class Calculator
        {
            // Calculates the total cost of all expensives and finds the most expensive item
            public double CalculateCost() 
            {
                char stop = 'N';
                int listAmount = 0;
                int index;
                double itemCost;
                double totalCost = 0;
                double max = 0;
                WriteLine("How many things are you currently paying for or want to buy?");
                listAmount = int.Parse(ReadLine());
                string[] itemsName = new string[listAmount];
                double[] itemsCost = new double[listAmount];
                while (stop != 'Y')
                {
                    // add items to a name list and cost list
                    for (int i = 0; i < listAmount; i++)
                    {
                        Write("Please enter the name of item: ");
                        itemsName[i] = Convert.ToString(ReadLine());
                        Write("Please enter how much does {0} cost: ", itemsName[i]);
                        itemsCost[i] = Convert.ToDouble(ReadLine());

                        Clear();
                    }
                    // Finds the largest cost vaule and rewrites the items name next to its cost
                    max = itemsCost[0];
                    for (int k = 0; k < listAmount; k++)
                    {
                        if (itemsCost[k] > max)
                        {
                            max = itemsCost[k];
                        }
                        WriteLine("{0} cost {1}", itemsName[k], itemsCost[k]);


                    }
                    // adds all values in itemsCost
                    foreach (double cost in itemsCost)
                    {
                        itemCost = cost;
                        totalCost = totalCost + itemCost;
                    }
                    // Allows users to double check and make sure they have inputed everything correctly
                    WriteLine("Is this all correct? If so enter Y if not enter N");
                    stop = Convert.ToChar(ReadLine());
                }
                Clear();
                //finds the name of the greast cost item and writes it as well as returning total cost to Main
                index = Array.BinarySearch(itemsCost, max);
                WriteLine("Your highest cost itme is {0} and cost {1}", itemsName[index], max.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                return totalCost;





            }
            // Calculates the remaining money you have after taxes and monthly expensives
            public double CalculateMontlyRemaingMoney(double balance, double expensives)
            {
                double remainBalance;
                remainBalance = balance - expensives;
                return remainBalance;
            }

        }
    }
}


