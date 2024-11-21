using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sudoku
{
    public class Sudoku
    {
        private Validations validate = new Validations();
        private PrintServices printServices = new PrintServices();

        private int[,] grid;
        private int[,] initialGrid;
        private readonly Random random = new Random();
        private int difficulty = 40; // Nombre de cases à vider pour créer le puzzle

        public Sudoku()
        {
            grid = new int[9,9];
            initialGrid = new int[9, 9];
        }

        public int[,] Grid 
        {
            get { return grid; } 
            set { grid = value; }
        }
        public int[,] InitialGrid
        {
            get { return initialGrid; }
            set { initialGrid = value; }
        }
        public Random Random
        {
            get { return random; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public void FillBox(int[,] grid, int row, int col)
        {
            if (row % 3 != 0 || col % 3 != 0)
            {
                throw new ArgumentException("Rangée et colonne doivent être un multiples de 3.");
            }

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    if (grid[i, j] != 0)
                    {
                        throw new InvalidOperationException("Les grilles doivent être vides.");
                    }
                }
            }

            int value = 1;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    grid[i, j] = value++;
                }
            }
        }

        public void FillDiagonal()
        {
            //3 carrés doivent avoir reçu des valeurs
            for (int i = 0; i < 9; i += 3)
            {
                FillBox(grid, i, i);
            }
        }

        public void RemoveNumbers(int emptyCells)
        {
            int removed = 0;

            while (removed < emptyCells)
            {
                // Choisir une rangée et une colonne aléatoire
                int row = random.Next(0, 9);
                int col = random.Next(0, 9);

                // Si la case est déjà vide, passer à la suivante
                if (grid[row, col] != 0)
                {
                    // Retinir la valeur de la case
                    grid[row, col] = 0;
                    removed++;
                }
            }
        }

        public bool SolveGrid(int[,] grid)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (grid[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (validate.IsSafe(grid, row, col, num))
                            {
                                grid[row, col] = num;

                                if (SolveGrid(grid))
                                {
                                    return true;
                                }

                                grid[row, col] = 0;
                            }
                        }

                        return false; // Aucun nombre valide
                    }
                }
            }

            return true; // Grid complétée
        }
    }
}
