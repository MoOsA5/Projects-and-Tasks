using System;
using System.Collections.Generic;

namespace Graph
{
    class ListGraph
    {
        private int n;
        private List<List<int>> list;

        public ListGraph(int numberOfVertices)
        {
            try
            {
                if (numberOfVertices <= 0)
                    throw new ArgumentException("Number of vertices must be greater than zero.");

                n = numberOfVertices;
                list = new List<List<int>>();

                for (int i = 0; i < n; i++)
                    list.Add(new List<int>());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating graph: " + ex.Message);
            }
        }

        public void AddEdge(int i, int j)
        {
            try
            {
                if (i < 0 || i >= n || j < 0 || j >= n)
                    throw new IndexOutOfRangeException("Vertex index is out of range.");

                list[i].Add(j);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding edge: " + ex.Message);
            }
        }

        public void DisplayAdjList()
        {
            try
            {
                if (list == null || list.Count == 0)
                    throw new InvalidOperationException("The list is empty or not initialized.");

                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{i}: ");
                    foreach (int j in list[i])
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying list: " + ex.Message);
            }
        }
    }
}
