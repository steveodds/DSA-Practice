using System;

namespace DSA_Practice
{
    class Program
    {
        private static readonly int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            
        }

        static void GetDays()
        {
            try
            {
                var days = DaysDatesCalculator.DaysBetweenDates(2013, 1, 24, 2024, 6, 29);
                System.Console.WriteLine($"Number of days: {days}. Number of years: {days / 365}");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
