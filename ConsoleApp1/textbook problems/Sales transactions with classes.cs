using System;
using static System.Console;
using System.Globalization;

namespace ConsoleApp1
{
    class ProgramSalesTransactionDemo
    {
        static void Main(string[] args)
        {
            {
                
            }
            public static void Display(SalesTransaction s)
            {
                
            }
            public static void DisplayTotal(SalesTransaction s)
            {
                
            }
        }

        public class SalesTransaction
        {
            public SalesTransaction(string name, double Salesamount, double rate)
            {
                this.Name = name;
                this.SalesAmount = Salesamount;
                this.Rate = rate;
                this.Commission = SalesAmount * rate;
            }
            public SalesTransaction(string name, double Salesamount)
            {
                this.Name = name;
                this.SalesAmount = Salesamount;
                this.Rate = 0;
                this.Commission = 0;
            }
            public SalesTransaction(string name)
            {
                this.Name = name;
                this.SalesAmount = 0;
                this.Rate = 0;
                this.Commission = 0;
            }
            public string Name { get; set; }
            public double SalesAmount { get; set; }

            public double Rate { get; set; }
            public double getRate() => Rate;

            public double Commission { get; set; }
            public static SalesTransaction operator +(SalesTransaction a, SalesTransaction b)
            {
                return new SalesTransaction(a.Name, a.SalesAmount + b.SalesAmount)
                {
                };
            }
        }
    }
}
