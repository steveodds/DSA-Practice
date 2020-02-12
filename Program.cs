using System.Collections.Generic;

namespace DSA_Practice
{
    class Program
    {
        private static readonly int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            try
            {
                var testNumbers = new CustomLinkedList<int>();
                testNumbers.Append(0);
                testNumbers.Append(1);
                testNumbers.Append(2);
                testNumbers.Append(3);
                testNumbers.Append(4);
                testNumbers.Append(5);

                

                while (!testNumbers.IsEmpty())
                {
                    System.Console.WriteLine(testNumbers.Last().data);
                    testNumbers.RemoveLast();
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
            }
        }




        //Tests DaysDatesCalculator
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
