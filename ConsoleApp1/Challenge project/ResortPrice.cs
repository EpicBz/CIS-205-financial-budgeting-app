using System;
using static System.Console;
namespace ConsoleApp1
{
    class ResortPrice
    {
        static void Main(string[] args)
        {
            // program needs to have information stored in an a array, that displays price per night and total price of stay, and the money saved if user stays for more than 2 nights based off of daily rates and basic rates
            //basic rate is 200
            // defines to seperate arrays for nights and rates
            int[] daysBooked = {1,2,3,4,5,6,7,8};
            int[] rates = { 200, 200, 180, 180, 160, 160, 160, 145 };   
            string requestedNights;
            int charge,searchNights,total, nights;
            // added a way to cancel booking as this would be a realsitc thing on a website to see
            WriteLine("Welcome guest. We currently have a discount going on if you stay with us more than 2 nights.");
            WriteLine("Please enter how many nights or enter 0 to cancel ; ");
            requestedNights = ReadLine();
            nights = Convert.ToInt32(requestedNights);
            // searchNights allows a user to input a number higher than 8 and applies the maxium discount they can have while nights holds on the user input
            if (nights > 8)
                searchNights = 8;
            else
                searchNights = Convert.ToInt32(requestedNights);
            // search for the corrasponding index number in rates array
            charge = Array.BinarySearch(daysBooked, searchNights);
            // if user inputs zero  this is the cancel promt. could have put a swithc but im more confrotable with if else
            if (charge < 0)
                WriteLine("Booking has been cancelled");
            if(nights >2)
                WriteLine("For {0}. The cost per night is {1}, your total cost is ${2}, you have saved ${3} per night for staying more than 2 nights.", requestedNights, rates[charge], total = rates[charge] * nights, rates[charge] -200);
            
            else
                WriteLine("For {0}. The cost per night is {1}, your total cost is ${2}", requestedNights, rates[charge], total = rates[charge] * nights);

        }
    }
}
