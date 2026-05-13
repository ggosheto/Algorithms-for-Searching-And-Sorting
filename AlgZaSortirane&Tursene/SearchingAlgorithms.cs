using System;
using System.Collections.Generic;
using System.Text;

namespace AlgZaSortirane_Tursene
{
    internal class SearchingAlgorithms
    {
        public static int LinearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearchWithLoop(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (right >= left)
            {
                int middle = (left + right) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }
                if (array[middle] > value)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        public static int BinarySearchWithRecursion(int[] array, int value)
        {
            return BinarySearchWithRecursion(array, value, 0, array.Length - 1);
        }

        private static int BinarySearchWithRecursion(int[] array, int value, int left, int right)
        {
            if (right >= left)
            {
                int middle = (left + right) / 2;
                if (array[middle] == value)
                {
                    return middle;
                }
                if (array[middle] > value)
                {
                    return BinarySearchWithRecursion(array, value, left, middle - 1);
                }
                else
                {
                    return BinarySearchWithRecursion(array, value, middle + 1, right);
                }
            }

            return -1;
        }
    }
}
