using System;

namespace Laboratory_work_7
{
    public class SinglyLinkedList
    {
        public void AddLast(float value)
        {
            Node newNode = new Node(value);
            if (head == null)
                head = newNode;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.Next = newNode;
            }
        }
        public void Remove(float value)
        {
            Node previous = null;
            Node current = head;
            if (current != null && current.Data == value)
                head = current.Next;
            else
            {
                while (current != null && current.Data != value)
                {
                    previous = current;
                    current = current.Next;
                }
                if (current == null)
                    throw new InvalidOperationException("There is no such element");
                previous.Next = current.Next;
            }
        }

        public int FindTheNumberOfElementsLargerFor(float value)
        {
            int number = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Data > value)
                    number++;
                current = current.Next;
            }
            return number;
        }
        public void RemoveElementsSmallerFor(float value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data < value)
                    Remove(current.Data);
                current = current.Next;
            }
        }

        internal Node GetLastNode()
        {
            Node lastNode = head;
            while (lastNode.Next != null)
                lastNode = lastNode.Next;
            return lastNode;
        }

        private Node head;
    }
}