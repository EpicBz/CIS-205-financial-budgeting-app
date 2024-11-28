using System;
using static System.Console;
using System.Globalization;

namespace ConsoleApp1
{
    class PayRollApp

    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            String employeeName = "Joshua Montain";
            double totalSales = 1;
            double grossPay = 1;
            double deductionsFederaltax = 1;
            double deductionsSocialSecurity = 1;
            double deductionsRetirement = 1;
            double totalDeductions = 1;
            double takeHomePay = 1;
            const double employeeCommissionEarn = .07;
            const double federalTax = .18;
            const double retirementProg = .10;
            const double socialSecurity = .06;
            WriteLine("What was total sales this month? ");
            totalSales = double.Parse(ReadLine());
            grossPay = (totalSales * employeeCommissionEarn);
            deductionsFederaltax = (grossPay * federalTax) ;
            deductionsSocialSecurity = (grossPay * socialSecurity);
            deductionsRetirement = (grossPay * retirementProg);
            totalDeductions = deductionsFederaltax + deductionsSocialSecurity + deductionsRetirement;
            takeHomePay = grossPay - totalDeductions;
            Convert.ToDecimal(totalSales);
            Convert.ToDecimal(grossPay);
            Convert.ToDecimal(deductionsFederaltax);
            Convert.ToDecimal(deductionsSocialSecurity);
            Convert.ToDecimal(deductionsRetirement);
            Convert.ToDecimal(totalDeductions);
            Convert.ToDecimal(takeHomePay);
            String totalMoney = grossPay.ToString("N");
            String govTax = deductionsFederaltax.ToString("N");
            String socialTax = deductionsSocialSecurity.ToString("N");
            String retirment = deductionsRetirement.ToString("N");
            String billCost = totalDeductions.ToString("N");
            String income = takeHomePay.ToString("N");
            WriteLine("        Employee:   {0}", employeeName);
            WriteLine("Total Sales:                         {0}", totalSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("Gross Pay (7%):                      {0}", totalMoney);
            WriteLine("Federal Taxes:                       {0}", govTax);
            WriteLine("Social Security Taxes:               {0}", socialTax);
            WriteLine("Retirement Contribution:             {0}", retirment);
            WriteLine("                               ________________");
            WriteLine("Total Deductions:                    {0}", billCost);
            WriteLine("");
            WriteLine("Take Home Pay:                       {0}", income);

            
        }
    }
}
