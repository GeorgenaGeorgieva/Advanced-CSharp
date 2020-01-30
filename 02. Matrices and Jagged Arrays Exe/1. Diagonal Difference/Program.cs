namespace DiagonalDifference
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int rows = sizeMatrix;
            int cols = sizeMatrix;
            
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colsInforamtion = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInforamtion[col];
                }
            }
            
            int sumPrimaryDiagonal = 0;
            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                if (currentRow >= matrix.GetLength(0) || currentCol >= matrix.GetLength(1))
                {
                    break;
                }

                sumPrimaryDiagonal += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }

            int sumSecondaryDiagonal = 0;
            currentRow = 0;
            currentCol = matrix.GetLength(1) - 1;

            while (true)
            {
                if (currentRow >= matrix.GetLength(0) || currentCol < 0)
                {
                    break;
                }

                sumSecondaryDiagonal += matrix[currentRow, currentCol];
                currentRow++;
                currentCol--;
            }
            
            int absDifference = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
            Console.WriteLine(absDifference);
        }
    }
}
