namespace KnightGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine()); 
            char[,] boardMatrix = new char[sizeMatrix, sizeMatrix]; 

            for (int row = 0; row < boardMatrix.GetLength(0); row++)
            {
                char[] colsInfo = Console.ReadLine().ToCharArray();

                for (int col = 0; col < boardMatrix.GetLength(1); col++)
                {
                    boardMatrix[row, col] = colsInfo[col];
                }
            }

            int countOfKillers = 0;
            int killerRow = 0;
            int killerCol = 0;
            
            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < boardMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < boardMatrix.GetLength(1); col++)
                    {
                        int currentKnightsAttacks = 0;

                        if (boardMatrix[row, col] == 'K')
                        {
                            if (IsInside(boardMatrix, row - 2, col + 1) && boardMatrix[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row - 2, col - 1) && boardMatrix[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row - 1, col + 2) && boardMatrix[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row - 1, col - 2) && boardMatrix[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row + 1, col + 2) && boardMatrix[row + 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row + 1, col - 2) && boardMatrix[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row + 2, col + 1) && boardMatrix[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(boardMatrix, row + 2, col - 1) && boardMatrix[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                        }

                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    boardMatrix[killerRow, killerCol] = '0';
                    countOfKillers++;
                }
                else
                {
                    Console.WriteLine(countOfKillers);
                    break;
                }
            }
        }
        
        public static bool IsInside(char[,] boardMatrix, int row, int col)
        {
            return row >= 0 && row < boardMatrix.GetLength(0) && col >= 0 && col < boardMatrix.GetLength(1);
        }
    }
}
