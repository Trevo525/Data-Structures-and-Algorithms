using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class ArrayStack
    {
        private Employee[] stack;
        private int top;

        public ArrayStack(int capacity)
        {
            stack = new Employee[capacity];
        }

        public void Push(Employee employee)
        {
            if (top == stack.Length)
            {
                // need to resize the backing array
                Employee[] newArray = new Employee[2 * stack.Length];
                
                Array.Copy(stack, 0, newArray, 0, stack.Length);
                stack = newArray;
            }

            stack[top++] = employee;
        }

        public Employee Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            Employee employee = stack[--top];
            stack[top] = null;
            return employee;
        }

        public Employee Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            return stack[top - 1];
        }

        public int Size()
        {
            return top;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public void PrintStack()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
