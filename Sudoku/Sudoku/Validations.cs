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
            // Vérifie si le nombre est déjà dans la ligne
            for (int i = 0; i < 9; i++)
            {
                if (i != col && grid[row, i] == grid[row, col])
                {
                    Console.WriteLine("Le nombre est déjà dans la ligne");
                    return false;
                }
            }

            // Vérifie si le nombre est déjà dans la colonne
            for (int i = 0; i < 9; i++)
            {
                if (i != row && grid[i, col] == grid[row, col])
                {
                    Console.WriteLine("Le nombre est déjà dans la colonne");
                    return false;
                }
            }

            // Vérifie si le nombre est déjà dans le carré
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (i != row && j != col && grid[i, j] == grid[row, col])
                    {
                        Console.WriteLine("Le nombre est déjà dans le carré");
                        return false;
                    }
                }
            }

            return true;
        }

        //public bool IsSafe(int[,] grid, int row, int col, int num)
        //{
        //    throw new NotImplementedException();
        //    //return IsValid(grid, row, col) && !IsInRow(grid, row, num) && !IsInCol(grid, col, num) && !IsInBox(grid, row - row % 3, col - col % 3, num);
        //}
    }
}
