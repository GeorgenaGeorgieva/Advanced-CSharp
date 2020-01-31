namespace SquareWithMaximumSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            
            int maxSum = int.MinValue;
            int maxRolIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var currentSum = matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRolIndex = row;
                        maxColIndex = col;
                    }
                }
            }
            
            Console.WriteLine($"{matrix[maxRolIndex, maxColIndex]} " +
                $"{matrix[maxRolIndex, maxColIndex + 1]}");

            Console.WriteLine($"{matrix[maxRolIndex + 1, maxColIndex]} " +
                $"{matrix[maxRolIndex + 1, maxColIndex + 1]}");

            Console.WriteLine(maxSum);
        }
    }
}
