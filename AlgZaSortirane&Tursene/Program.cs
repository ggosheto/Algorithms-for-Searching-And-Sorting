using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgZaSortirane_Tursene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 5, 4, 8, 2, 9, 7 };
            Console.WriteLine("Unsorted Array: " + string.Join(", ", array));

            Console.WriteLine();

            //SortingAlgorithms.QuickSortClass.QuickSort(array, 0, array.Length - 1);
            //SortingAlgorithms.MergeSortClass.MergeSort(array, 0, array.Length - 1);

            SortingAlgorithms.RadixSortClass.RadixSort(array);
            Console.WriteLine("Sorted Array: " + string.Join(", ", array));

            Console.WriteLine();
            Console.ReadKey();
        } 
        
    }
}
