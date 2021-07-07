using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class Heap
    {
        private int[] heap;
        private int size;

        public Heap(int capacity)
        {
            heap = new int[capacity];
        }

        public void Insert(int value)
        {
            if (IsFull())
            {
                throw new Exception("Heap is full");
            }

            heap[size] = value;

            FixHeapAbove(size);
            size++;

        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Heap is empty");
            }
            return heap[0];
        }

        public int Delete(int index)
        {
            if (IsEmpty())
            {
                throw new Exception("Heap is Empty");
            }

            int parent = GetParent(index);
            int deletedValue = heap[index];

            heap[index] = heap[size - 1];

            if (index == 0 || heap[index] < heap[parent])
            {
                FixHeapBelow(index, size - 1);
            }
            else
            {
                FixHeapAbove(index);
            }

            size--;

            return deletedValue;
        }

        public void Sort()
        {
            int lastHeapIndex = size - 1;
            for (int i = 0; i < lastHeapIndex; i++)
            {
                int tmp = heap[0];
                heap[0] = heap[lastHeapIndex - i];
                heap[lastHeapIndex - i] = tmp;

                FixHeapBelow(0, lastHeapIndex - i - 1);
            }
        }

        private void FixHeapBelow(int index, int lastHeapIndex)
        {
            int childToSwap;

            // compare node at index to it's children
            while (index <= lastHeapIndex)
            {
                int leftChild = GetChild(index, true);
                int rightChild = GetChild(index, false);
                if (leftChild <= lastHeapIndex)
                {
                    if (rightChild > lastHeapIndex)
                    {
                        childToSwap = leftChild;
                    }
                    else
                    {
                        childToSwap = (heap[leftChild] > heap[rightChild] ? leftChild : rightChild);
                    }
                    if (heap[index] < heap[childToSwap])
                    {
                        int tmp = heap[index];
                        heap[index] = heap[childToSwap];
                        heap[childToSwap] = tmp;
                    }
                    else
                    {
                        break;
                    }
                    index = childToSwap;
                }
                else
                {
                    break;
                }
            }
        }

        private void FixHeapAbove(int index)
        {
            int newValue = heap[index];
            while (index > 0 && newValue > heap[GetParent(index)])
            {
                heap[index] = heap[GetParent(index)];
                index = GetParent(index);
            }

            heap[index] = newValue;
        }

        public void PrintHeap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(heap[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }

        public bool IsFull()
        {
            return size == heap.Length;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }

        public int GetChild(int index, bool left)
        {
            return 2 * index + (left ? 1 : 2);
        }
    }
}
