using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
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

            char[,] matrix = new char[rows, cols];

            var inputSnake = Console.ReadLine().ToCharArray();

            Queue<char> snakeQueue = new Queue<char>(inputSnake);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        SnakeMoves(matrix, snakeQueue, row, col);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        SnakeMoves(matrix, snakeQueue, row, col);
                    }
                } 
            }
            PrintMatrix(matrix);
        }   
        static void SnakeMoves(char[,] matrix, Queue<char> snakeQueue, int row, int col)
        {
            
            matrix[row, col] = snakeQueue.Peek();
            snakeQueue.Enqueue(snakeQueue.Peek());
            snakeQueue.Dequeue();
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
