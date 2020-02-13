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

                System.Console.WriteLine($"Contains 2?: {testNumbers.Contains(2)}");

                while (!testNumbers.IsEmpty())
                {
                    System.Console.Write(testNumbers.Last().data + " : ");
                    testNumbers.RemoveLast();
                }

                testNumbers.Append(0);
                testNumbers.Append(1);
                testNumbers.Append(2);
                testNumbers.Append(3);
                testNumbers.Append(4);
                testNumbers.Append(5);

                testNumbers.AddAfter(testNumbers.Find(0), 10);
                testNumbers.AddBefore(testNumbers.Last(), 11);

                System.Console.WriteLine("After AddAfter and AddBefore:");
                while (!testNumbers.IsEmpty())
                {
                    System.Console.Write(testNumbers.First().data + " : ");
                    testNumbers.RemoveFirst();
                }

                testNumbers.Append(0);
                testNumbers.Append(1);
                testNumbers.Append(2);
                testNumbers.Append(3);
                testNumbers.Append(4);
                testNumbers.Append(5);

                System.Console.WriteLine($"Has {testNumbers.Count()}");
                
                testNumbers.AddLast(1001);
                testNumbers.AddFirst(1000);
                System.Console.WriteLine(testNumbers.First().data);
                System.Console.WriteLine(testNumbers.Last().data);
                System.Console.WriteLine("Removing first and last:");
                testNumbers.RemoveFirst();
                testNumbers.RemoveLast();
                System.Console.WriteLine(testNumbers.First().data);
                System.Console.WriteLine(testNumbers.Last().data);
                testNumbers.Clear();
                System.Console.WriteLine($"Has {testNumbers.Count()}");

                testNumbers.Append(0);
                testNumbers.Append(1);
                testNumbers.Append(2);
                testNumbers.Append(3);
                testNumbers.Append(4);
                testNumbers.Append(5);
                testNumbers.Remove(10);

                while (!testNumbers.IsEmpty())
                {
                    System.Console.Write(testNumbers.First().data + " : ");
                    testNumbers.RemoveFirst();
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
