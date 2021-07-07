using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class EmployeeDoublyLinkedList
    {
        private EmployeeDoubleNode head;
        private EmployeeDoubleNode tail;
        private int size;

        public void AddToFront(Employee employee)
        {
            EmployeeDoubleNode node = new EmployeeDoubleNode(employee);
            node.SetNext(head);

            if (head == null)
            {
                tail = node;
            }
            else
            {
                head.SetPrevious(node);
            }

            head = node;
            size++;
        }

        public void AddToEnd(Employee employee)
        {
            EmployeeDoubleNode node = new EmployeeDoubleNode(employee);
            if (tail == null)
            {
                head = node;
            }
            else
            {
                tail.SetNext(node);
                node.SetPrevious(tail);
            }

            tail = node;
            size++;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public EmployeeDoubleNode RemoveFromFront()
        {
            if (IsEmpty())
            {
                return null;
            }
            EmployeeDoubleNode removedNode = head;

            if (head.GetNext() == null)
            {
                tail = null;
            }
            else
            {
                head.GetNext().SetPrevious(null);
            }

            head = head.GetNext();
            size--;
            removedNode.SetNext(null);
            return removedNode;
        }

        public EmployeeDoubleNode RemoveFromEnd()
        {
            if (IsEmpty())
            {
                return null;
            }
            EmployeeDoubleNode removeNode = tail;

            if (tail.GetPrevious() == null)
            {
                head = null;
            }
            else
            {
                tail.GetPrevious().SetNext(null);
            }

            tail = tail.GetPrevious();
            size--;
            removeNode.SetNext(null);
            return removeNode;
        }

        public void PrintList()
        {
            EmployeeDoubleNode current = head;
            Console.Write("HEAD -> ");
            while (current != null)
            {
                Console.Write(current);
                Console.Write(" <=> ");
                current = current.GetNext();
            }
            Console.WriteLine("null");
        }
    }
}
