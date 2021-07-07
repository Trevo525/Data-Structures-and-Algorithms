using Data_Structures_and_Algorithms.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms
{
    class Stacks
    {
        internal static void ArrayImplementation()
        {
            ArrayStack stack = new ArrayStack(10);

            stack.Push(new Employee("Jane", "Jones", 123));
            stack.Push(new Employee("John", "Doe", 4567));
            stack.Push(new Employee("Mary", "Smith", 22));
            stack.Push(new Employee("Mike", "Wilson", 3245));
            stack.Push(new Employee("Bill", "End", 78));

            stack.PrintStack();


            Console.WriteLine("Popped: " + stack.Pop());
            Console.WriteLine(stack.Peek());
        }

        internal static void LinkedListImplem()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);
            Employee billEnd = new Employee("Bill", "End", 78);


            LinkedStack stack = new LinkedStack();
            stack.Push(janeJones);
            stack.Push(johnDoe);
            stack.Push(marySmith);
            stack.Push(mikeWilson);
            stack.Push(billEnd);

            Console.WriteLine(stack.Peek());
            stack.printStack();
            Console.WriteLine("Popped: " + stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}
