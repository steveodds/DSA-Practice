using System;
namespace DSA_Practice
{
    class CustomStack<T>
    {
        public int Capacity { get; private set; }
        private int _numberOfElements;
        private T[] _elements;
        public CustomStack(int capacity)
        {
            if(capacity < 2)
                throw new ArgumentException("A stack needs to be able to hold more than one element");
            Capacity = capacity;
            _elements = new T[Capacity];
        }

        //Stack opertions
        public void Push(T value)
        {
            //Adds value to the stack
            if(_numberOfElements == Capacity)
                throw new InvalidOperationException("The stack is full.");
            _elements[_numberOfElements++] = value;
        }

        public T Top()
        {
            //Returns most recently added value
            if(_numberOfElements < 1)
                throw new InvalidOperationException("The stack has no values.");
            return _elements[_numberOfElements - 1];
        }

        public T Pop()
        {
            //Removes and returns most recently added Key
            if(_numberOfElements < 1)
                throw new InvalidOperationException("The stack has no values.");
            return _elements[--_numberOfElements];
        }

        public bool IsEmpty()
        {
            //Checks if there are any elements
            return _numberOfElements == 0;
        }

        public bool Contains(T value)
        {
            //Checks if the Stack contains the given value
            for (int i = 0; i < _numberOfElements; i++)
            {
                if(_elements[i].Equals(value))
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            //Clears the stack
            _numberOfElements = 0;
        }
        public int Count()
        {
            return _numberOfElements;
        }
    }
}
