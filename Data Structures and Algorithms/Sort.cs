using System;

namespace Data_Structures_and_Algorithms
{
    class Sort
    {
        public static void BubbleSort(int[] array)
        {
            for (int lastUnsortedIndex = array.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                for (int i = 0; i < lastUnsortedIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int lastUnsortedIndex = array.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {

                int largest = 0;

                for (int i = 1; i <= lastUnsortedIndex; i++)
                {
                    if (array[i] > array[largest])
                    {
                        largest = i;
                    }
                }

                Swap(array, largest, lastUnsortedIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int firstUnsortedIndex = 1; firstUnsortedIndex < array.Length; firstUnsortedIndex++)
            {
                int newElement = array[firstUnsortedIndex];
                int i;

                for (i = firstUnsortedIndex; i > 0 && array[i - 1] > newElement; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = newElement;
            }
        }

        internal static void RadixSort(int[] input, int radix, int width)
        {
            for (int i = 0; i < width; i++)
            {
                RadixSingleSort(input, i, radix);
            }
        }

        private static void RadixSingleSort(int[] input, int position, int radix)
        {
            int numItems = input.Length;

            int[] countArray = new int[radix];

            foreach(int value in input)
            {
                countArray[GetDigit(position, value, radix)]++;
            }

            // Adjust the count array
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }

            int[] temp = new int[numItems];
            for (int tempIndex = numItems - 1; tempIndex >= 0; tempIndex--)
            {
                temp[--countArray[GetDigit(position, input[tempIndex], radix)]] = input[tempIndex];
            }

            for (int tempIndex = 0; tempIndex < numItems; tempIndex++)
            {
                input[tempIndex] = temp[tempIndex];
            }

        }

        private static int GetDigit(int position, int value, int radix)
        {
            return value / (int)Math.Pow(10, position) % radix;
        }

        internal static void CountingSort(int[] input, int min, int max)
        {
            int[] countArray = new int[(max - min) + 1];

            // Increment the count
            for (int i = 0; i < input.Length; i++)
            {
                countArray[input[i] - min]++;
            }

            // Sort based on count
            int j = 0;
            for (int i = min; i <= max; i++)
            {
                while (countArray[i - min] > 0)
                {
                    input[j++] = i;
                    countArray[i - min]--;
                }
            }
        }

        internal static void QuickSort(int[] intArray)
        {
            Recursion.QuickSort(intArray, 0, intArray.Length);
        }

        public static void ShellSort(int[] array)
        {
            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {

                for (int i = gap; i < array.Length; i++)
                {

                    int newElement = array[i];

                    int j = i;

                    while (j >= gap && array[j - gap] > newElement)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = newElement;
                }

            }
        }

        public static void MergeSort(int[] array)
        {
            // This method just calls the recursive method.
            // This allows to add the start and end dynamically.
            Recursion.MergeSort(array, 0, array.Length);
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
