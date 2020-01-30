namespace 2x2SquaresInMatrix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colsInformation = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInformation[col];
                }
            }
            
            int countOfEqualSquares = 0;
            
            for (int row = 0; row < (matrix.GetLength(0) - 1); row++)
            {
                for (int col = 0; col < (matrix.GetLength(1) - 1); col++)
                {
                    if (matrix[row,col] == matrix[row, col + 1] 
                        && matrix[row, col] == matrix[row + 1, col] 
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        countOfEqualSquares++;
                    }
                }
            }
            
            Console.WriteLine(countOfEqualSquares);
        }
    }
}
