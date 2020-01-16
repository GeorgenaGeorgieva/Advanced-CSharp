using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colsInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInfo[col];
                }
            }

            int maxSum = int.MinValue;
            int[,] tripleMatrix = new int[3, 3];

            for (int row = 0; row < (matrix.GetLength(0) - 2); row++)
            {
                for (int col = 0; col < (matrix.GetLength(1) - 2); col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        tripleMatrix = new int[,] {
                            {matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]},
                            {matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                            {matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]}
                        };
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < tripleMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < tripleMatrix.GetLength(1); col++)
                {
                    Console.Write(tripleMatrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
