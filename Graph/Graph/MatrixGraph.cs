using System;

namespace Graph
{
    class MatrixGraph
    {
        private int n;
        private int[,] matrix;

        public MatrixGraph(int numberOfVertices)
        {
            try
            {
                if (numberOfVertices <= 0)
                    throw new ArgumentException("Number of vertices must be greater than zero.");
                n = numberOfVertices;
                matrix = new int[n, n];
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
                matrix[i, j] = 1;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid vertex index. Please enter values between 0 and " + (n - 1));
            }
        }

        public void Display()
        {
            try
            {
                Console.Write("  ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying matrix: " + ex.Message);
            }
        }
    }
}
