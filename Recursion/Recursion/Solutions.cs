using System;
using System.Collections.Generic;

namespace Recursion
{
    class Solutions
    {
        public static int MaxNumber(List<int> list)
        {
            int n = list.Count;
            //Base Case
            if (n == 1)
            {
                return list[0];
            }
            //Recursion Case
            int mid = n / 2;
            int left = MaxNumber(list.GetRange(0, mid));
            int right = MaxNumber(list.GetRange(mid, n-mid));

            return left > right ? left : right;
        }

        public static int MinNumber(List<int> list)
        {
            int n = list.Count;
            //Base Case
            if (n == 1)
            {
                return list[0];
            }
            //Recursion Case
            int mid = n / 2;
            int left = MinNumber(list.GetRange(0, mid));
            int right = MinNumber(list.GetRange(mid, n - mid));

            return left < right ? left : right;
        }

        public static int Sum(List<int> list)
        {
            int n = list.Count;
            //Base Case
            if (n == 1)
            {
                return list[0];
            }
            //Recursion Case
            int mid = n / 2;
            int left = Sum(list.GetRange(0, mid));
            int right = Sum(list.GetRange(mid, n - mid));
       
            return left + right;
        }

        public static void BinarySearch(List<int> list,int target)
        {
            int low = 0, high = list.Count - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (list[mid] == target)
                    Console.WriteLine($"The target {target} is at index {mid}");

                if (list[mid] < target)
                    low = mid + 1;

                else
                    high = mid - 1;
            }
        }

        public static List<int> QuickSort(List<int> list)
        {
            int n = list.Count;
            List<int> sortedList = new List<int>();
            //Base Case
            if (n == 1)
            {
                return list;
            }
            //Recursion Case
            int pivot = n / 2;
            List<int> left = QuickSort(list.GetRange(0, pivot));
            List<int> right = QuickSort(list.GetRange(pivot, n - pivot));

            sortedList.Add(pivot);
            return sortedList;
        }

    }
}
