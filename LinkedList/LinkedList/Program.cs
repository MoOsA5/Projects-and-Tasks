using System;
using System.Collections.Generic;
using System.Linq;
using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        HMLinkedList<int> myList = new HMLinkedList<int>();
        myList.AddLast(10);
        myList.AddLast(20);
        myList.AddLast(30);
        myList.AddLast(40);
        
        //myList.AddFirst(5);

        //myList.AddLast(45);

        //myList.RemoveLast();
        //myList.RemoveFirst();
        //myList.AddAtPosition(25,4);

        //myList.RemoveAtPosition(0);
        myList.RemoveByValue(50);

        myList.PrintLinkedList(myList);

        Console.WriteLine(myList.Count());
        Console.WriteLine("is there 25 ? " + myList.IsContain(25));
        //LinkedList<int> list = null;

        //while (true)
        //{
        //    Console.WriteLine("\n==== LinkedList Menu ====");
        //    Console.WriteLine("1. Create LinkedList");
        //    Console.WriteLine("2. Print LinkedList");
        //    Console.WriteLine("3. Insert At Beginning");
        //    Console.WriteLine("4. Insert At End");
        //    Console.WriteLine("5. Insert At Position");
        //    Console.WriteLine("6. Delete First Node");
        //    Console.WriteLine("7. Delete Last Node");
        //    Console.WriteLine("8. Delete by Value");
        //    Console.WriteLine("9. Reverse List");
        //    Console.WriteLine("10. Middle Node");
        //    Console.WriteLine("11. Count Nodes");
        //    Console.WriteLine("12. Search in List");
        //    Console.WriteLine("13. Exit");
        //    Console.Write("Choose an option: ");

        //    var choice = Console.ReadLine();
        //    Console.WriteLine();
        //    try
        //    {
        //        switch (choice)
        //        {
        //            case "1":
        //                Console.Write("Enter numbers separated by space: ");
        //                var input = Console.ReadLine()
        //                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        //                    .Select(int.Parse)
        //                    .ToArray();
        //                list = Solutions.CreateLinkedList(input);
        //                Console.WriteLine("LinkedList created.");
        //                break;

        //            case "2":
        //                Solutions.PrintLinkedList(list);
        //                break;

        //            case "3":
        //                Console.Write("Enter value: ");
        //                int val1 = int.Parse(Console.ReadLine());
        //                list = Solutions.InsertAtBeginning(list, val1);
        //                break;

        //            case "4":
        //                Console.Write("Enter value: ");
        //                int val2 = int.Parse(Console.ReadLine());
        //                list = Solutions.InsertAtEnd(list, val2);
        //                break;

        //            case "5":
        //                Console.Write("Enter value: ");
        //                int val3 = int.Parse(Console.ReadLine());
        //                Console.Write("Enter position: ");
        //                int pos = int.Parse(Console.ReadLine());
        //                list = Solutions.InsertAtPosition(list, val3, pos);
        //                break;

        //            case "6":
        //                list = Solutions.DeleteFirstNode(list);
        //                Console.WriteLine("First node deleted.");
        //                break;

        //            case "7":
        //                list = Solutions.DeleteLastNode(list);
        //                Console.WriteLine("Last node deleted.");
        //                break;

        //            case "8":
        //                Console.Write("Enter value to delete: ");
        //                int val4 = int.Parse(Console.ReadLine());
        //                list = Solutions.DeletebyValue(list, val4);
        //                Console.WriteLine("Value deleted.");
        //                break;

        //            case "9":
        //                list = Solutions.Reverse(list);
        //                Console.WriteLine("List reversed.");
        //                break;

        //            case "10":
        //                var mid = Solutions.MiddleNode(list);
        //                Console.WriteLine($"Middle Node: {mid.Value}");
        //                break;

        //            case "11":
        //                Console.WriteLine($"Length = {Solutions.CountNodes(list)}");
        //                break;

        //            case "12":
        //                Console.Write("Enter value to search: ");
        //                int target = int.Parse(Console.ReadLine());
        //                Console.WriteLine(Solutions.SearchInLinkedList(list, target)
        //                    ? "Found!"
        //                    : "Not found!");
        //                break;

        //            case "13":
        //                return;

        //            default:
        //                Console.WriteLine("Invalid choice.");
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //}
        Console.ReadKey();
    }
}
