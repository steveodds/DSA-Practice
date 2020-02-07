using System;
using System.Text;

namespace DSA_Practice
{
    class Program
    {
        private static readonly int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            try
            {
                var days = DaysBetweenDates(2013, 1, 24, 2013, 6, 29);
                System.Console.WriteLine($"First date, number of days: {days}.");

                days = DaysBetweenDates(1912, 12, 12, 2012, 12, 12);
                System.Console.WriteLine($"Second date, number of days: {days}.");

                days = DaysBetweenDates(2013, 1, 1, 2013, 1, 1);
                System.Console.WriteLine($"Third date, number of days: {days}.");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
        }


        static int[] NextDay(int year, int month, int day)
        {
            //
            // Summary:
            //     Assumes every month has 30 days
            var nextDate = new int[] { year, month, day };
            if (day == 30)
            {
                nextDate[2] = 1;
                if (month == 12)
                {
                    nextDate[1] = 1;
                    nextDate[0]++;
                    return nextDate;
                }
                nextDate[1]++;
                return nextDate;
            }
            nextDate[2]++;

            return nextDate;
        }
        static int DaysBetweenDates(int y1, int m1, int d1, int y2, int m2, int d2)
        {
            var dateError = "The second date must come after the first date.";
            if (y1 > y2)
                throw new ArgumentException(dateError);

            if (y1 == y2 && m1 > m2)
                throw new ArgumentException(dateError);

            if ((y1 == y2 && m1 == m2) && d1 > d2)
                throw new ArgumentException(dateError);


            int days = 0;
            int[] nextDate = new int[3];
            int[] date1 = new int[] { y1, m1, d1 };
            int[] date2 = new int[] { y2, m2, d2 };
            while (!IsEqualToDate(date1, date2))
            {
                nextDate = NextDay(date1[0], date1[1], date1[2]);
                date1[0] = nextDate[0];
                date1[1] = nextDate[1];
                date1[2] = nextDate[2];
                days++;
            }

            return days;
        }

        static bool IsEqualToDate(int[] date, int[] dateToCompare)
        {
            return date[0] == dateToCompare[0] && date[1] == dateToCompare[1] && date[2] == dateToCompare[2];
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
