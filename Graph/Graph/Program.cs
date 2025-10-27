using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixGraph G1 = new MatrixGraph(4);
            G1.AddEdge(0, 1);
            G1.AddEdge(0, 2);
            G1.AddEdge(1, 2);
            G1.AddEdge(2, 3);

            G1.Display();

            Console.WriteLine("---------------");

            ListGraph L1 = new ListGraph(4);
            L1.AddEdge(0, 1);
            L1.AddEdge(0, 2);
            L1.AddEdge(1, 2);
            L1.AddEdge(2, 3);

            L1.DisplayAdjList();
        }
    }
}
