using System.Globalization;

namespace AlgZaSortirane_Tursene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] array = new[] { 1, 5, 4, 8, 2, 9, 7 };

            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine();
            
            SortingAlgorithms.CountingSort(array);
            Console.Write("Sorted Array: ");
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }

            //Console.WriteLine();

            ////Console.WriteLine(SearchingAlgorithms.BinarySearchWithRecusrion(array, 4)); 


            Console.WriteLine();
            Console.ReadKey();
        } 
        
    }
}
