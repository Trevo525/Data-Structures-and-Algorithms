using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class EmployeeLinkedList
    {
        private EmployeeNode head;
        private int size;

        public void AddToFront(Employee employee)
        {
            EmployeeNode node = new EmployeeNode(employee);
            node.SetNext(head);
            head = node;
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

        public EmployeeNode RemoveFromFront()
        {
            if (IsEmpty())
            {
                return null;
            }
            EmployeeNode removedNode = head;
            head = head.getNext();
            size--;
            removedNode.SetNext(null);
            return removedNode;
        }

        public void PrintList()
        {
            EmployeeNode current = head;
            Console.Write("HEAD -> ");
            while (current != null)
            {
                Console.Write(current);
                Console.Write(" -> ");
                current = current.getNext();
            }
            Console.WriteLine("null");
        }
    }
}
