using Data_Structures_and_Algorithms.Objects;
using System;
using System.Collections;

namespace Data_Structures_and_Algorithms
{
    class Lists
    {
        internal static void ArrayLists()
        {
            ArrayList employeeList = new ArrayList();
            employeeList.Add(new Employee("Jane", "Jones", 123));
            employeeList.Add(new Employee("John", "Doe", 4567));
            employeeList.Add(new Employee("Mary", "Smith", 22));
            employeeList.Add(new Employee("Mike", "Wilson", 3245));

            printlist(employeeList);

            employeeList.Insert(1, new Employee("John", "Adams", 4568));
            Console.WriteLine("Print with added John: ");
            printlist(employeeList);

            // Print # of items in the array
            Console.Write("# of items in the array: ");
            Console.WriteLine(employeeList.Count);

            employeeList.Insert(3, new Employee("John", "Doe", 4567));
            Console.WriteLine("Print with another added John Doe");
            printlist(employeeList);


            Object[] employeeArray = employeeList.ToArray();
            Console.WriteLine("Print Array List");
            foreach (Employee employee in employeeArray)
            {
                Console.WriteLine(employee);
            }

            Console.Write("This list contains Employee(\"Mary\", \"Smith\", 22): ");
            Console.WriteLine(employeeList.Contains(new Employee("Mary", "Smith", 22)));

            Console.Write("Index of Employee(\"John\", \"Doe\", 4567): ");
            Console.WriteLine(employeeList.IndexOf(new Employee("John", "Doe", 4567)));

            employeeList.RemoveAt(2);

            Console.WriteLine("Print with object at index 2 removed:");
            printlist(employeeList);

            static void printlist(ArrayList employeeList)
            {
                foreach (var employee in employeeList)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        internal static void Vectors()
        {
            /*
             * C# is different from Java in that it's Vector class (System.Numerics.Vector) can only
             * contain non-nullable types. This means that it can take only primitive values in practice.
             * Instead, the closest equivalent is an ArrayList that has been synchronized like below.
             */

            ArrayList employeeList = new ArrayList();
            ArrayList syncdEmployeeList = ArrayList.Synchronized(employeeList);

            // The Synchronized version works the same as the non-syncronized version.
            //syncdEmployeeList.Add(new Employee("Jane", "Jones", 123));
            //syncdEmployeeList.Add(new Employee("John", "Doe", 4567));
            //syncdEmployeeList.Add(new Employee("Mary", "Smith", 22));
            //syncdEmployeeList.Add(new Employee("Mike", "Wilson", 3245));

            // Displays the sychronization status of both ArrayLists.s
            Console.WriteLine("employeeList is {0}.", employeeList.IsSynchronized ? "synchronized" : "not synchronized");
            Console.WriteLine("syncdEmployeeList is {0}.", syncdEmployeeList.IsSynchronized ? "synchronized" : "not synchronized");
        }

        internal static void SinglyLinkedLists()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);

            EmployeeLinkedList list = new EmployeeLinkedList();

            Console.WriteLine("Linked List is Empty: " + list.IsEmpty());

            list.AddToFront(janeJones);
            list.AddToFront(johnDoe);
            list.AddToFront(marySmith);
            list.AddToFront(mikeWilson);

            list.PrintList();
            Console.WriteLine(list.GetSize());

            Console.WriteLine("Removed from front: " + list.RemoveFromFront());
            Console.WriteLine(list.GetSize());
        }

        internal static void DoublyLinkedLists()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);

            EmployeeDoublyLinkedList list = new EmployeeDoublyLinkedList();

            Console.WriteLine("Is Empty: " + list.IsEmpty());

            list.AddToFront(janeJones);
            list.AddToFront(johnDoe);
            list.AddToFront(marySmith);
            list.AddToFront(mikeWilson);

            list.PrintList();
            Console.WriteLine("Get Size: " + list.GetSize());

            Employee billEnd = new Employee("Bill", "End", 78);
            list.AddToEnd(billEnd);
            Console.WriteLine("Bill has been added to the end");
            list.PrintList();
            Console.WriteLine("Get Size: " + list.GetSize());

            list.RemoveFromFront();
            list.PrintList();
            Console.WriteLine("Get Size: " + list.GetSize());

            list.RemoveFromEnd();
            list.PrintList();
            Console.WriteLine("Get Size: " + list.GetSize());
        }
    }
}
