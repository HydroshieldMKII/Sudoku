using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Validations
    {
        public bool IsValid(int[,] grid, int row, int col)
        {
            if (IsNumberInRow(grid, row, col))
            {
                Console.WriteLine("Le nombre est déjà dans la ligne");
                return false;
            }

            if (IsNumberInColumn(grid, row, col))
            {
                Console.WriteLine("Le nombre est déjà dans la colonne");
                return false;
            }

            if (IsNumberInSquare(grid, row, col))
            {
                Console.WriteLine("Le nombre est déjà dans le carré");
                return false;
            }

            return true;
        }

        private bool IsNumberInRow(int[,] grid, int row, int col)
        {
            int number = grid[row, col];
            for (int i = 0; i < 9; i++)
            {
                if (i != col && grid[row, i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsNumberInColumn(int[,] grid, int row, int col)
        {
            int number = grid[row, col];
            for (int i = 0; i < 9; i++)
            {
                if (i != row && grid[i, col] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsNumberInSquare(int[,] grid, int row, int col)
        {
            int number = grid[row, col];
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (i != row && j != col && grid[i, j] == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsSafe(int[,] grid, int row, int col, int number)
        {
            // Check if the number is already in the row
            for (int i = 0; i < 9; i++)
            {
                if (grid[row, i] == number)
                {
                    return false;
                }
            }

            // Check if the number is already in the column
            for (int i = 0; i < 9; i++)
            {
                if (grid[i, col] == number)
                {
                    return false;
                }
            }

            // Check if the number is already in the square
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (grid[i, j] == number)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
