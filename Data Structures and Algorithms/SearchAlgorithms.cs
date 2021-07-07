using Data_Structures_and_Algorithms.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms
{
    class SearchAlgorithms
    {
        internal static void LinearSearch()
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            int index = LinearSearch(intArray, 7);

            Console.WriteLine(LinearSearch(intArray, 7));
            Console.WriteLine(LinearSearch(intArray, 1));
            Console.WriteLine(LinearSearch(intArray, 111111));
            Console.WriteLine(LinearSearch(intArray, -22));
        }

        private static int LinearSearch(int[] intArray, int value)
        {

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        internal static void BinarySearch()
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            //Must be sorted. Algorithm doesn't matter.
            Sort.MergeSort(intArray);

            Console.WriteLine(IterativeBinarySearch(intArray, 7));
            Console.WriteLine(IterativeBinarySearch(intArray, 1));
            Console.WriteLine(IterativeBinarySearch(intArray, 111111));
            Console.WriteLine(IterativeBinarySearch(intArray, -22));

            Console.WriteLine(RecursiveBinarySearch(intArray, 7));
            Console.WriteLine(RecursiveBinarySearch(intArray, 1));
            Console.WriteLine(RecursiveBinarySearch(intArray, 111111));
            Console.WriteLine(RecursiveBinarySearch(intArray, -22));
        }

        public static int RecursiveBinarySearch(int[] input, int value)
        {
            return RecursiveBinarySearch(input, 0, input.Length, value);
        }

        private static int RecursiveBinarySearch(int[] input, int start, int end, int value)
        {
            if (start >= end)
                return -1;

            int midpoint = (start + end) / 2;
            if (input[midpoint] == value)
            {
                return midpoint;
            }
            else if (input[midpoint] < value)
            {
                return RecursiveBinarySearch(input, midpoint + 1, end, value);
            }
            else
            {
                return RecursiveBinarySearch(input, start, midpoint, value);
            }
        }

        public static int IterativeBinarySearch(int[] input, int value)
        {
            int start = 0;
            int end = input.Length;

            while (start < end)
            {
                int midpoint = (start + end) / 2;
                if (input[midpoint] == value)
                {
                    return midpoint;
                }
                else if (input[midpoint] < value)
                {
                    start = midpoint + 1;
                }
                else
                {
                    end = midpoint;
                }
            }
            return -1;
        }

        internal static void BinarySearchTree()
        {
            Tree intTree = new Tree();
            intTree.Insert(25);
            intTree.Insert(20);
            intTree.Insert(15);
            intTree.Insert(27);
            intTree.Insert(30);
            intTree.Insert(29);
            intTree.Insert(26);
            intTree.Insert(22);
            intTree.Insert(32);
            intTree.Insert(17);

            intTree.TraverseInOrder();
            Console.WriteLine();

            Console.WriteLine(intTree.Get(27));
            Console.WriteLine(intTree.Get(17));
            Console.WriteLine(intTree.Get(8888));

            Console.WriteLine("Max = " + intTree.Max());
            Console.WriteLine("Min = " + intTree.Min());

            intTree.Delete(15);
            intTree.TraverseInOrder();
            Console.WriteLine();
            intTree.Delete(17);
            intTree.TraverseInOrder();
            Console.WriteLine();
            intTree.Delete(25);
            intTree.TraverseInOrder();
            Console.WriteLine();
        }

        internal static void Heaps()
        {
            Heap heap = new Heap(10);

            heap.Insert(80);
            heap.Insert(75);
            heap.Insert(60);
            heap.Insert(68);
            heap.Insert(55);
            heap.Insert(40);
            heap.Insert(52);
            heap.Insert(67);

            heap.PrintHeap();

            heap.Delete(1);
            heap.Delete(5);
            heap.PrintHeap();

            Console.WriteLine("root = " + heap.Peek());
        }

        internal static void HeapSort()
        {
            Heap heap = new Heap(10);

            heap.Insert(80);
            heap.Insert(75);
            heap.Insert(60);
            heap.Insert(68);
            heap.Insert(55);
            heap.Insert(40);
            heap.Insert(52);
            heap.Insert(67);

            heap.PrintHeap();

            //heap.Delete(1);
            //heap.Delete(5);
            //heap.PrintHeap();

            //Console.WriteLine("root = " + heap.Peek());

            heap.Sort();
            heap.PrintHeap();
        }
    }
}
