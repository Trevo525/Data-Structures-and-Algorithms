using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class ArrayQueue
    {
        private Employee[] queue;
        private int front;
        private int back;

        public ArrayQueue(int capacity)
        {
            queue = new Employee[capacity];
        }

        public void Add(Employee employee)
        {
            if (back == queue.Length)
            {
                Employee[] newArray = new Employee[2 * queue.Length];
                Array.Copy(queue, 0, newArray, 0, queue.Length);
                queue = newArray;
            }

            queue[back] = employee;
            back++;
        }

        public Employee Remove()
        {
            if (Size() == 0)
            {
                throw new Exception("Queue is empty!");
            }
            Employee employee = queue[front];
            queue[front] = null;
            front++;

            if (Size() == 0)
            {
                front = 0;
                back = 0;
            }
            return employee;
        }

        public Employee Peek()
        {
            if (Size() == 0)
            {
                throw new Exception("Queue is empty!");
            }

            return queue[front];
        }

        public int Size()
        {
            return back - front;
        }

        public void PrintQueue()
        {
            for (int i = front; i < back; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
