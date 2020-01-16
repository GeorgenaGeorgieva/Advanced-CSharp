using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matrix_shuffling
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
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colsInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInfo[col];
                }
            }

            while (true)
            {
                string[] operations = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = operations[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "swap" && operations.Length == 5)
                {

                    int firstRow = int.Parse(operations[1]);
                    int firstCol = int.Parse(operations[2]);
                    int secondRow = int.Parse(operations[3]);
                    int secondCol = int.Parse(operations[4]);

                    if (firstRow >= 0 && firstRow <= rows - 1 && firstCol >= 0 && firstCol <= cols - 1
                        && secondRow >= 0 && secondRow <= rows - 1 && secondCol >= 0 && secondCol <= cols - 1)
                    {
                        var currentCell = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = currentCell;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }
    }
}
