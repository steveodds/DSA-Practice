using System;

namespace DSA_Practice
{
    class CustomStackList<T>
    {
        private CustomLinkedList<T> stackList;
        public CustomStackList()
        {
            stackList = new CustomLinkedList<T>();
        }


        public void Push(T value)
        {
            //Adds value to the stack
            stackList.AddFirst(value);
        }

        public T Top()
        {
            //Returns most recently added value
            if(stackList.Count() < 1)
                throw new InvalidOperationException("The stack has no values.");
            return stackList.Head.data;
        }

        public T Pop()
        {
            //Removes and returns most recently added Key
            if(stackList.Count() < 1)
                throw new InvalidOperationException("The stack has no values.");
            
            var value = stackList.Head.data;
            stackList.RemoveFirst();
            return value;
        }

        public bool IsEmpty()
        {
            //Checks if there are any elements
            return stackList.IsEmpty();
        }

        public bool Contains(T value)
        {
            //Checks if the Stack contains the given value
            return stackList.Contains(value);
        }

        public void Clear()
        {
            //Clears the stack
            stackList.Clear();
        }
        public int Count()
        {
            return stackList.Count();
        }
    }
}
