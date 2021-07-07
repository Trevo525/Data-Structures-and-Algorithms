using Data_Structures_and_Algorithms.Objects;
using System;


namespace Data_Structures_and_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortingAlgorithms();
            //ListsLesson();
            //StacksLesson();
            //QueuesLesson();
            //HashtablesLesson();
            SearchAlgorithmsLesson();


            // Test Employee.Equals()
            //Employee emp1 = new Employee("Trevor", "Vance", 525);
            //Employee emp2 = new Employee("Trevor", "Vance", 525);
            //Console.WriteLine("emp1 == emp2: "+ emp1.Equals(emp2));
        }

        private static void SortingAlgorithms()
        {
            Sorting();
            RecursionLesson();
            Sorting2();
        }

        private static void RecursionLesson()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Recursion.Factorial(i) != Recursion.IterativeFactorial(i)) //Iterative (non-recursive) Factorial
                {
                    Console.WriteLine("Uh oh. This is embarrasing.. Your Math is wrong. Factorials at i = " + i);
                }
                Console.WriteLine(i + "! = " + Recursion.Factorial(i));       //Recursive Factorial
            }
        }

        private static void Sorting()
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };
            PrintIntArray(intArray);

            Sort.BubbleSort(intArray);        // Bubble Sort
            Sort.SelectionSort(intArray);     // Selection Sort
            Sort.InsertionSort(intArray);     // Insertion Sort
            Sort.ShellSort(intArray);         // Shell Sort

            PrintIntArray(intArray);
        }

        private static void Sorting2()
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };
            int[] countingSortArray = { 2, 5, 9, 8, 2, 8, 7, 10, 4, 3 };
            int[] radixSortArray = { 4725, 4586, 1330, 8792, 1594, 5729 };

            PrintIntArray(intArray);
            PrintIntArray(countingSortArray);
            PrintIntArray(radixSortArray);

            Sort.MergeSort(intArray);                       // Merge Sort
            Sort.QuickSort(intArray);                       // Quick Sort
            Sort.CountingSort(countingSortArray, 1, 10);    // Counting Sort
            Sort.RadixSort(radixSortArray, 10, 4);          // Radix Sort

            PrintIntArray(intArray);
            PrintIntArray(countingSortArray);
            PrintIntArray(radixSortArray);
        }

        private static void ListsLesson()
        {
            Lists.ArrayLists();
            Lists.Vectors();
            Lists.SinglyLinkedLists();
            Lists.DoublyLinkedLists();
        }

        private static void StacksLesson()
        {
            Stacks.ArrayImplementation();
            Stacks.LinkedListImplem();
        }

        private static void QueuesLesson()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);
            Employee billEnd = new Employee("Bill", "End", 78);

            ArrayQueue queue = new ArrayQueue(10);
            queue.Add(janeJones);
            queue.Add(johnDoe);
            queue.Add(marySmith);
            queue.Add(mikeWilson);
            queue.Add(billEnd);
            queue.PrintQueue();

            queue.Remove();
            queue.Remove();
            Console.WriteLine("Queue after 2 removals:");
            queue.PrintQueue();

            Console.WriteLine("Peek: " + queue.Peek());
            queue.Remove();
            queue.Remove();
            //queue.Remove();
            //queue.Remove();
            //queue.Remove();
            queue.PrintQueue();
        }

        private static void HashtablesLesson()
        {
            HashTables.ArrayImplementation();
            HashTables.ChainedHashTable();
            HashTables.BucketSort();
        }

        private static void SearchAlgorithmsLesson()
        {
            //SearchAlgorithms.LinearSearch();
            //SearchAlgorithms.BinarySearch();
            //SearchAlgorithms.BinarySearchTree();
            //SearchAlgorithms.Heaps();
            SearchAlgorithms.HeapSort();
            
        }

        private static void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i] + "\n");
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
        }
    }
}
