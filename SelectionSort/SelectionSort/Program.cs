using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 2, 9, 1, 7 };

            Algorithm.PrintArray(arr1);

            Algorithm.SelectionSort(arr1);

            Algorithm.PrintArray(arr1);
            Console.WriteLine();

            Decimal[] arr2 = new Decimal[] { 3.2m, 1.5m, 4.7m, 2.8m };

            Algorithm.PrintArray(arr2);

            Algorithm.SelectionSort(arr2);

            Algorithm.PrintArray(arr2);
            Console.WriteLine();


            char[] arr3 = new char[] { 'z', 'b', 'a', 'c' };

            Algorithm.PrintArray(arr3);

            Algorithm.SelectionSort(arr3);

            Algorithm.PrintArray(arr3);
            Console.WriteLine();

            String[] arr4 = new String[] { "Ali", "Sara", "Zain", "Maryam" };

            Algorithm.PrintArray(arr4);

            Algorithm.SelectionSort(arr4);

            Algorithm.PrintArray(arr4);
            Console.WriteLine();


            Console.ReadKey();
        }
        
    }
}
