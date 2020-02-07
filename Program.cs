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
                var date = NextDay(2020, 12, 31);
                System.Console.WriteLine($"Date after 31st, December 2020 is {date[2]}/{date[1]}/{date[0]}.");
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
            if (day > DaysInMonth(year, month) || day < 1)
                throw new ArgumentException("An invalid day was given.");
            
            var nextDate = new int[] { year, month, day };
            
            if (day == DaysInMonth(year, month))
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

        static int DaysInMonth(int year, int month)
        {
            var daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year == 0)
                throw new ArgumentException("The year given was invalid.");

            if (month < 1 || month > 12)
                throw new ArgumentException("The month given was out of range.");

            if (IsLeapYear(year) && month == 2)
                return 29;
            else
                return daysInMonth[month - 1];
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
