using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    jaggedArr[row][col] = currentRow[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    break;
                }
                var commandParts = command.Split(" ");
                var commandOperator = commandParts[0];
                var commandRow = int.Parse(commandParts[1]);
                var commandCol = int.Parse(commandParts[2]);
                var commandValue = int.Parse(commandParts[3]);

                if (commandRow < 0 || commandRow >= jaggedArr.Length 
                    || commandCol < 0 || commandCol >= jaggedArr[commandRow].Length)
                {
                    Console.WriteLine($"Invalid coordinates");
                    continue;
                }
                if (commandOperator.ToLower() == "add") 
                {
                    jaggedArr[commandRow][commandCol] += commandValue;
                }
                else if (commandOperator.ToLower() == "subtract")
                {
                    jaggedArr[commandRow][commandCol] -= commandValue;
                }
            }

            foreach (var row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
