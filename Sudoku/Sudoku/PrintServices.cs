using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class PrintServices
    {
        private Validations validate = new Validations();

        /// <summary>Affiche dans la console les directives du menu principal.</summary>
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Générer une grille");
            Console.WriteLine("2. Charger une grille sauvegardée (sudoku_save.json)");
            Console.WriteLine("3. Sélectionner un niveau de difficulté");
            Console.WriteLine("4. Quitter");
            Console.WriteLine("================");
            Console.Write("Choisissez une option : ");
        }

        /// <summary>Affiche les options de modification pour le niveau de difficulté</summary>
        /// <param name="difficulty">Doit afficher la difficulté actuel</param>
        public void PrintDifficultySelect(int difficulty)
        {
            Console.Clear();
            Console.WriteLine("===== Niveaux de difficulté =====");
            Console.WriteLine($"Niveau de difficulté actuel : {difficulty}");
            Console.WriteLine("1. Facile (30 cases vides)");
            Console.WriteLine("2. Moyen (40 cases vides)");
            Console.WriteLine("3. Difficile (50 cases vides)");
            Console.WriteLine("4. Très difficile (60 cases vides)");
            Console.WriteLine("=================================");
            Console.WriteLine("Choisissez un niveau de difficulté (1-4) : ");
        }

        /// <summary>Afficher la grille de Sudoku</summary>
        /// <param name="grid">Reçoit la grille de jeu à imprimé contenant les entrées du joueur</param>
        /// <param name="initialGrid">Reçoit la grille d'origine pour différencier la couleur à afficher</param>
        /// <param name="final">Affiche tout en bleu lorsque on reconnait que la grille est complétée</param>
        public void PrintGrid(int[,] grid, int[,] initialGrid, bool final = false)
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                if (i == 0) Console.WriteLine("      1 2 3   4 5 6   7 8 9  "); 

                if (i % 3 == 0) Console.WriteLine("    + ----- + ----- + ----- + "); 

                char rowChar = (char)('A' + i);
                Console.Write($"  {rowChar} ");

                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0) Console.Write("| ");

                    if (initialGrid[i, j] != 0) Console.Write(initialGrid[i, j] + " ");
                    else if (grid[i, j] != 0)
                    {
                        if (final) Console.ForegroundColor = ConsoleColor.Blue; 
                        else if (validate.IsValid(grid, i, j)) Console.ForegroundColor = ConsoleColor.Green;
                        else Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(grid[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else Console.Write(". ");
                }
                Console.WriteLine("| ");
            }
            Console.WriteLine("    + ----- + ----- + ----- + \n");
        }
    }
}
