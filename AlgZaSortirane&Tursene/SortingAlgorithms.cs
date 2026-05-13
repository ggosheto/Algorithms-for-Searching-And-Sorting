using System;
using System.Collections.Generic;
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
    }
}
