namespace PrimaryDiagonal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            
            int sumDiagonalElements = 0;
            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                if (currentRow >= matrix.GetLength(0) || currentCol >= matrix.GetLength(1))
                {
                    break;
                }
                
                sumDiagonalElements += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }
            
            Console.WriteLine(sumDiagonalElements);
        }
    }
}
