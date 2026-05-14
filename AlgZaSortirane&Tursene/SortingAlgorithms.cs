using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace AlgZaSortirane_Tursene
{
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
        }

        public static void BubbleSortWithFLag(int[] array)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int swap = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swap;
                        flag = true;
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            int i, j, minIndex;

            for (i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int swap = array[minIndex];
                array[minIndex] = array[i];
                array[i] = swap;
            }
                
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int index = i;
                while (index > 0 && array[index - 1] > value)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = value;
            }

            return array;
        }

        public static int[] CountingSort(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int[] count = new int[max + 1];
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }

            return output;
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high) // // Method inheriated by QuickSort
        {
            int pivot = array[high];
            Console.WriteLine($"Chosen PIVOT: {pivot} (on position {high})");
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] array, int a, int b) // Method inheriated by QuickSort
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void MergeSort(int[] array, int left, int right) // Method Inheriated by MergeSort
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private static void Merge(int[] array, int left, int mid, int right) // Method Inheriated by MergeSort
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftTemp = new int[n1];
            int[] rightTemp = new int[n2];

            Array.Copy(array, left, leftTemp, 0, n1);
            Array.Copy(array, mid + 1, rightTemp, 0, n2);

            int i = 0;
            int j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftTemp[i] < rightTemp[j])
                {
                    array[k] = leftTemp[i];
                    i++;
                }
                else
                {
                    array[k] = rightTemp[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k++] = leftTemp[i++];
            }

            while (j < n2)
            {
                array[k++] = rightTemp[j++];
            }
        }
    }
}
