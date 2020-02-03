using System;
using System.Text;

namespace DSA_Practice
{
    class Program
    {
        private static readonly int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            /* var days = DaysBetweenDates(2012, 1, 1, 2012, 1, 2);
            Console.WriteLine($"{days} days."); */

            var date1 = nextDay(1999, 12, 30);
            var date2 = nextDay(2013, 1, 30);
            var date3 = nextDay(2012, 12, 30);
            var builder = new StringBuilder();

            foreach (var date in date1)
            {
                builder.Append(date + ", ");
            }
            builder.Append("\n");
            foreach (var date in date2)
            {
                builder.Append(date + ", ");
            }
            builder.Append("\n");
            foreach (var date in date3)
            {
                builder.Append(date + ", ");
            }
            System.Console.WriteLine(builder);
        }


        static int[] nextDay(int year, int month, int day)
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
            var days = 0;
            for (int birthYear = y1 + 1; birthYear < y2 - 1; birthYear++)
            {
                days += IsLeapYear(birthYear) ? 366 : 365;
            }

            for (int birthMonth = m1 < 11 ? m1 + 1 : m1; birthMonth < 12 - m1; birthMonth++)
            {
                days += IsLeapYear(y1) && birthMonth == 2 ? 29 : daysOfMonths[birthMonth];
            }

            for (int currentMonth = m2 > 1 ? m2 - 1 : m2; currentMonth > 0 && currentMonth < 12; currentMonth++)
            {
                days += IsLeapYear(y2) && currentMonth == 2 ? 29 : daysOfMonths[currentMonth];
            }

            days += d2;
            days += IsLeapYear(y1) && m1 == 2 ? 29 - d1 : daysOfMonths[m1] - d1;

            return days;
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
