using System;
using static System.Console;
using System.Globalization;
namespace ConsoleApp1
{
    class TakeHomePay
    {
        static void Main(string[] args)
        {
            string  firstName, lastName, id, type;
            const double overtimeHourly = 1.5;
            const double federalTax = 0.18;
            const double socialSecurityTax = 0.06;
            const double retirementContribution = 0.1;
            double deduction, hourlyRate, totalHours, salary, hrPay, income, fed, social, retirement;
            WriteLine("What is employee's First name? :");
            firstName = ReadLine();
            WriteLine("What is employee's Last name? :");
            lastName = ReadLine();
            WriteLine("What is employee's Id? :");
            id = ReadLine();
            WriteLine("Are they paid hourly or salaried? (Please write in lower case)");
            type = ReadLine();
            switch(type)
            {
                case "hourly":
                    WriteLine("What is their hourly Rate? :");
                    hourlyRate = double.Parse(ReadLine());
                    WriteLine("What was the hours they worked? :");
                    totalHours = double.Parse(ReadLine());
                    if (totalHours > 40)
                        hrPay = (hourlyRate * 40) + (hourlyRate * overtimeHourly) * (totalHours - 40);
                    else
                        hrPay = hourlyRate * totalHours;
                    fed = (hrPay * federalTax);
                    social = (hrPay * socialSecurityTax);
                    retirement = (hrPay * retirementContribution);
                    deduction = fed + social + retirement;
                    income = hrPay - deduction;
                    WriteLine("Employee's Name {0} {1}", firstName, lastName);
                    WriteLine("Hourly pay:                                {0}", hourlyRate.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    WriteLine("Total hours worked:                        {0}", totalHours);
                    WriteLine("Total pay without tax deductions:          {0}", hrPay.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    WriteLine("Federal taxes:                             {0}", fed);
                    WriteLine("Social Secuity taxes:                      {0}", social);
                    WriteLine("Retirement Contribution:                   {0}", retirement);
                    WriteLine("Total amount of deductions due to taxes:   {0}", deduction.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    WriteLine("");
                    WriteLine("                                        -------------");
                    WriteLine("");
                    WriteLine("Total take home pay:                       {0}", income.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    break;
                case "Salaried":
                    WriteLine("What is their salary? :");
                    salary = double.Parse(ReadLine());
                    fed = (salary * federalTax);
                    social = (salary * socialSecurityTax);
                    retirement =(salary * retirementContribution);
                    deduction = fed + social + retirement;
                    income = salary - deduction;
                    WriteLine("Employee's Name {0} {1}", firstName, lastName);
                    WriteLine("Total pay without tax deductions:          {0}", salary.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    WriteLine("Federal taxes:                             {0}", fed);
                    WriteLine("Social Secuity taxes:                      {0}", social);
                    WriteLine("Retirement Contribution:                   {0}", retirement);
                    WriteLine("Total amount of deductions due to taxes:   {0}", deduction.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    WriteLine("");
                    WriteLine("                                        -------------");
                    WriteLine("");
                    WriteLine("Total take home pay:                       {0}", income.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    break;
                default:
                    WriteLine("Error incorrect way of payment");
                    break;

            }
            


        }
    }
}
