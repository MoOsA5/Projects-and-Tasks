using System;
using System.Collections.Generic;
namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(){ 3, 10, 5, 7, 20, 15};
            List<int> list2 = new List<int>() { 1, 3, 5, 7, 9 };
            //List<int> sortedList = Solutions.QuickSort(list);

            Console.WriteLine($"Lagest Number is : {Solutions.MaxNumber(list)}");
            Console.WriteLine($"Smallest Number is : {Solutions.MinNumber(list)}");
            Console.WriteLine($"Sum of numbers : {Solutions.Sum(list)}");
            Solutions.BinarySearch(list2,7);

            Console.ReadKey();
        }
    }
}
