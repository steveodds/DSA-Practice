using System;
using System.Collections.Generic;

namespace DSA_Practice
{
    class Program
    {
        private static readonly int[] daysOfMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>();
            LinkedList<int> testList = new LinkedList<int>();
            
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

    public class CustomList<T>
    {
        public Node<T> Head { get; set; }
        public CustomList()
        {
            
        }

        public void Append(T value)
        {
            var node = new Node<T>(value);
            if (Head == null)
                Head = node;
            
        }

        public void Remove(T value)
        {

        }

        public void Clear()
        {

        }

        public int Count()
        {
            throw new NotImplementedException();
        }
        public bool Contains(T value)
        {

            return false;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public class Node<TNode>
        {
            public TNode data;
            public Node<TNode> next;

            public Node(TNode value)
            {
                data = value;
                next = null;
            }
        }
    }
}
