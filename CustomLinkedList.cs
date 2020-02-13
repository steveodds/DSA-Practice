using System;

namespace DSA_Practice
{
    public class CustomLinkedList<T>
    {
        //TODO Implement TAIL
        public Node<T> Head { get; set; }
        public CustomLinkedList()
        {

        }


        //Operations on the front end of the list
        public void AddFirst(T value)
        {
            //Adds a node to the begining of the list
            var newValue = new Node<T>(value);
            newValue.Next = Head;
            Head = newValue;
        }

        public Node<T> First()
        {
            //Returns the first element of the list
            return Head;
        }

        public void RemoveFirst()
        {
            //Removes the first element of the list
            if (Head == null)
                throw new InvalidOperationException("The list is empty.");
            Head = Head.Next;
        }

        //Operations on the back end of the list
        public void AddLast(T value)
        {
            //Adds element to the back of the list
            if (Head == null)
                Head = new Node<T>(value);
            else
            {
                var temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node<T>(value);
            }
        }

        public Node<T> Last()
        {
            //Returns the last element in the list
            var temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            return temp;
        }

        public void RemoveLast()
        {
            //Removes last element in the list
            if (Head == null)
                throw new InvalidOperationException("The linked list is empty!");

            if (Head.Next == null)
                Head = null;
            else
            {
                var temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
            }
        }


        //Other operations
        public Node<T> Find(T value)
        {
            //Finds node with the given value
            if (Head == null)
                throw new InvalidOperationException("The list is empty!");
            var temp = Head;
            while (!temp.data.Equals(value))
            {
                temp = temp.Next;
                if (temp.Next == null && !temp.data.Equals(value))
                {
                    return null;
                }
            }
            return temp;
        }

        public void Append(T newValue)
        {
            AddLast(newValue);
        }
        public void AddBefore(Node<T> beforeElement, T newValue)
        {
            //Adds element before the specified node
            var newElement = new Node<T>(newValue);
            var temp = Head;
            while (temp.Next != beforeElement)
            {
                temp = temp.Next;
            }
            newElement.Next = beforeElement;
            temp.Next = newElement;
        }

        public void AddAfter(Node<T> afterElement, T newValue)
        {
            //Adds element after the specified node
            var newElement = new Node<T>(newValue);
            newElement.Next = afterElement.Next;
            afterElement.Next = newElement;
        }

        public void Remove(T value)
        {
            //Erases element from the list
            var toRemove = Find(value);
            if (toRemove == null)
                throw new InvalidOperationException("Cannot remove non-existent value.");
            var beforeRemoved = Head;
            if (toRemove == Head)
                RemoveFirst();
            else if (toRemove == Last())
                RemoveLast();
            else
            {
                while (beforeRemoved.Next != toRemove)
                {
                    beforeRemoved = beforeRemoved.Next;
                }
                beforeRemoved.Next = toRemove.Next;
            }
        }

        public void Clear()
        {
            Head = null;
        }

        public int Count()
        {
            //Returns the number of elements in the list
            if (Head == null)
                return 0;
            var temp = Head;
            var count = Head == null ? 0 : 1;
            while (temp.Next != null)
            {
                temp = temp.Next;
                count++;
            }

            return count;
        }
        public bool Contains(T value)
        {
            //Finds or checks if element is in the list
            return Find(value) != null;
        }

        public bool IsEmpty()
        {
            //Checks if the list has any elements
            return Head == null;
        }

        public class Node<TNode>
        {
            public TNode data;
            public Node<TNode> Next;

            public Node(TNode value)
            {
                data = value;
                Next = null;
            }
        }
    }
}
