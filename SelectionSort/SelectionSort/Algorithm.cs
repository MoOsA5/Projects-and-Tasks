using System;
namespace SelectionSort
{
    class Algorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {

                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        min = j;
                    }
                }

                T temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
