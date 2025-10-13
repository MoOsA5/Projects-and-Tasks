using System;
using System.Collections.Generic;
using System.Linq;

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
            //Base Case
            if (n < 2)
            {
                return list;
            }
            //Recursion Case
            else
            {
                int pivot = list[0];
                List<int> less = list.Skip(1).Where(i => i <= pivot).ToList();
                List<int> greater = list.Skip(1).Where(i => i > pivot).ToList();
                List<int> sorted = new List<int>();
                sorted.AddRange(QuickSort(less));
                sorted.Add(pivot);
                sorted.AddRange(QuickSort(greater));
                return sorted;
            }
        }

        public static int QuickSearch(List<int> list,int k)//3
        {
            List<int> sortedList = QuickSort(list);
            return sortedList[k - 1];
        }

    }
}
