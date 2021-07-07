using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class LinkedStack
    {
        private LinkedList<Employee> stack;

        public LinkedStack()
        {
            stack = new LinkedList<Employee>();
        }

        public void Push(Employee employee)
        {
            stack.AddFirst(employee);
        }

        public Employee Pop()
        {
            Employee employee = stack.First.Value;
            stack.RemoveFirst();
            return employee;
        }

        public Employee Peek()
        {
            return stack.First.Value;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public void printStack()
        {
            LinkedList<Employee> stack = new LinkedList<Employee>();

            for (LinkedListNode<Employee> node = stack.First; node != null; node = node.Next)
            {
                Console.WriteLine(node);
            }
        }
    }
}
