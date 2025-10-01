using System.Collections.Generic;
using System;

namespace LinkedList
{
    class Solutions
    {
        //A Generic Method to create LinkedList
        //params means method accepts unlimited number of values to the method without having to manually group them into an array or a list 
        public static LinkedList<T> CreateLinkedList<T>(params T[] list)
        {
            //check if List is null or Empty
            if (list == null || list.Length == 0)
                throw new ArgumentException("Input array is null or empty.", nameof(list));
            
            var newList = new LinkedList<T>();
            foreach (var L in list)
            {
                newList.AddLast(L);
            }
            return newList;
        }

        public static void PrintLinkedList<T>(LinkedList<T> List)
        {
            //check if List is null or Empty
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");
            if (IsEmpty<T>(List))
                throw new InvalidOperationException("List is empty.");

            foreach (var L in List)
            {
                Console.Write(L + " ");
            }
            Console.WriteLine();
        }

        public static int CountNodes<T>(LinkedList<T> List)
        {
            //check if List is null
            if (List == null)
            {
                throw new ArgumentNullException(nameof(List), "List is null.");
            }
            return List.Count;
        }

        public static bool SearchInLinkedList<T>(LinkedList<T> List, T target)
        {
            //check if List is null or Empty
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");
            if (IsEmpty<T>(List))
                throw new InvalidOperationException("List is empty.");

            return List.Contains(target);
        }

        public static LinkedList<T> InsertAtBeginning<T>(LinkedList<T> List, T value)
        {
            //check if List is null or Empty
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");

            List.AddFirst(value);
            return List;
        }

        public static LinkedList<T> InsertAtEnd<T>(LinkedList<T> List, T value)
        {
            //check if List is null or Empty
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");

            List.AddLast(value);
            return List;
        }

        public static LinkedList<T> InsertAtPosition<T>(LinkedList<T> List, T value, int position)
        {
            // Check if list is null
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");

            // Check if list is empty
            if (IsEmpty<T>(List))
            {
                Console.WriteLine("The list is empty. Value will be added as the first node.");
                List.AddFirst(value);
                return List;
            }

            // Check if position is out of range
            if (position < 0 || position > List.Count)
                throw new ArgumentOutOfRangeException(nameof(position), "Invalid position.");

            if (position == List.Count)
            {
                List.AddLast(value);
                return List;
            }

            var current = List.First;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            List.AddBefore(current, value);
            return List;
        }

        public static LinkedList<T> DeleteFirstNode<T>(LinkedList<T> List)
        {
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");
               
            if (IsEmpty<T>(List))
                throw new InvalidOperationException("List is empty.");

            List.RemoveFirst();
            return List;
        }

        public static LinkedList<T> DeleteLastNode<T>(LinkedList<T> List)
        {
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");

            if (IsEmpty<T>(List))
                throw new InvalidOperationException("List is empty.");

            List.RemoveLast();
            return List;
        }

        public static LinkedList<T> DeletebyValue<T>(LinkedList<T> List, T value)
        {
            if (List == null)
                throw new ArgumentNullException(nameof(List), "List is null.");

            if (IsEmpty<T>(List))
                throw new InvalidOperationException("List is empty.");

            var node = List.Find(value);
            if (node == null)
                throw new InvalidOperationException("Value not found in the list.");

            List.Remove(node);
            return List;
        }

        public static LinkedList<T> Reverse<T>(LinkedList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "List is null.");

            if (IsEmpty<T>(list))
                throw new InvalidOperationException("List is empty.");

            var reversed = new LinkedList<T>();
            var current = list.Last;

            while (current != null)
            {
                reversed.AddLast(current.Value);
                current = current.Previous;
            }

            return reversed;
        }

        public static LinkedListNode<T> MiddleNode<T>(LinkedList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "List is null.");

            if (IsEmpty<T>(list))
                throw new InvalidOperationException("List is empty.");

            var indexOfMiddleNode = CountNodes<T>(list)/2;
            var current = list.First;
            for (int i = 0; i < indexOfMiddleNode; i++)
            {
                current = current.Next;
            }
            return current;
        }

        public static int DedectLengthByIterative<T>(LinkedList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "List is null.");
            
            int counter = 0;
            var current = list.First;
            while (current != null)
            {
                counter++;
                current = current.Next;
            }
            return counter;
        }

        public static int DedectLengthByRecursive<T>(LinkedList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "List is null.");

            int counter = 0;
            var current = list.Last;
            while (current != null)
            {
                counter++;
                current = current.Previous;
            }
            return counter;
        }

        public static bool IsEmpty<T>(LinkedList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "List is null.");

            return CountNodes<T>(list) == 0 ? true : false;
        }
    }
}
