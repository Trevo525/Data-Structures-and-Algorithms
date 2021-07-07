using System;

namespace Data_Structures_and_Algorithms
{
    class Recursion
    {
        public static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        /// <summary>
        /// This is not recursive at all. I just included it next to the Recursion.factorial function for comparison
        /// </summary>
        public static int IterativeFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        internal static void MergeSort(int[] array, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }

            // partition the array
            int mid = (start + end) / 2;
            // The recurssion here splits the array until it is multiple arrays of size one.
            MergeSort(array, start, mid);
            MergeSort(array, mid, end);
            // This next section takes the previous (sorted) arrays and merges them into a bigger, sorted, array.
            Merge(array, start, mid, end);
        }

        internal static void Merge(int[] input, int start, int mid, int end)
        {
            if (input[mid - 1] <= input[mid])
            {
                return;
            }

            int i = start;
            int j = mid;
            int tempIndex = 0;

            int[] temp = new int[end - start];

            while (i < mid && j < end)
            {
                temp[tempIndex++] = input[i] <= input[j] ? input[i++] : input[j++];// the equal on this line is what makes
                                                                                   // this a stable algorithm
            }

            Array.Copy(input, i, input, start + tempIndex, mid - i);
            Array.Copy(temp, 0, input, start, tempIndex);
        }

        internal static void QuickSort(int[] input, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }

            int pivotIndex = Partition(input, start, end);
            QuickSort(input, start, pivotIndex);
            QuickSort(input, pivotIndex + 1, end);
        }

        private static int Partition(int[] input, int start, int end)
        {
            // this is using the first element as the pivot
            int pivot = input[start];
            int i = start;
            int j = end;

            while (i < j)
            {

                // NOTE: empty loop body
                while (i < j && input[--j] >= pivot) ;
                if (i < j)
                {
                    input[i] = input[j];
                }

                // NOTE: empty loop body
                while (i < j && input[++i] <= pivot) ;
                if (i < j)
                {
                    input[j] = input[i];
                }

            }

            input[j] = pivot;
            return j;
        }
    }
}
