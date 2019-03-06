using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Enumerations
{
    public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    public enum MonthsOfYear { 
            January = 1, February = 2, March = 3, April = 4, May = 5, 
            June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

    class Program
    {
        static void Main(string[] args)
        {
            //1. Days of the Week
            //DaysOfWeek today;
            //today = DaysOfWeek.Wednesday;
            //Console.WriteLine($"today: {today}");

            //int dayAsInt = (int)DaysOfWeek.Saturday; // Converts Sat to int which is 6
            //Console.WriteLine($"dayAsInt: {dayAsInt}");

            //today = (DaysOfWeek)dayAsInt; // Converts 6 to DaysOfWeek type which is Saturday
            //Console.WriteLine($"today: {today}");

            //2. TIO: Page 85: Months of the Year

            Console.WriteLine("Enter a month number 1 - 12:");
            string monthAsString = Console.ReadLine();
            int monthAsInt = Convert.ToInt32(monthAsString);
            Console.WriteLine($"month: {monthAsInt}");

            if (monthAsInt > 0 && monthAsInt <= 12)
            {
                MonthsOfYear selectedMonth = (MonthsOfYear)monthAsInt;
                Console.WriteLine($"selectedMonth: {selectedMonth}");
            } else
            {
                Console.WriteLine($"The number you provided is not within the month integer range: {monthAsInt}");
            }


            Console.ReadKey();
        }
    }
}
