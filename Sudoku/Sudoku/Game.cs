using System.Text.Json;

namespace Sudoku
{
    /// <summary>Jeu basique de Sudoku en console.</summary>
    public class Game
    {
        Sudoku sudoku = new Sudoku();
        private Validations validate = new Validations();
        private PrintServices printServices = new PrintServices();
        private SudokuFile sFile = new SudokuFile();

        /// <summary>Lancer le jeu + Menu principal</summary>
        public void Launch()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            printServices.PrintMainMenu();

            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        sudoku.GenerateSudokuGrid();
                        printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
                        PlayGame();
                        break;
                    case "2":
                        sFile.LoadGridFromJson(sudoku.Grid, sudoku.InitialGrid, "sudoku_save.json");
                        printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
                        PlayGame();
                        break;
                    case "3":
                        printServices.PrintDifficultySelect(sudoku.Difficulty);
                        string diffChoice = Console.ReadLine();
                        switch (diffChoice)
                        {
                            case "1":
                                sudoku.Difficulty = 30;
                                break;
                            case "2":
                                sudoku.Difficulty = 40;
                                break;
                            case "3":
                                sudoku.Difficulty = 50;
                                break;
                            case "4":
                                sudoku.Difficulty = 60;
                                break;
                            default:
                                Console.WriteLine("Choix invalide");
                                break;
                        }
                        printServices.PrintMainMenu();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
        }
        private void PlayGame()
        {
            string error = null;
            while (true)
            {
                printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
                Console.WriteLine("Entrez votre coup (par exemple, A1 5).Autre options: menu, solve ou save.");
                if (error != null)
                {
                    Console.WriteLine(error);
                }
                string input = Console.ReadLine();

                if (input.ToLower() == "menu")
                {
                    printServices.PrintMainMenu();
                    break;
                }

                if (input.ToLower() == "solve") 
                { 
                    sudoku.SolveGrid();
                    printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
                    Console.WriteLine("Grille résolue. Appuyez sur une touche pour continuer.");
                    Console.ReadKey();
                    printServices.PrintMainMenu();
                    break;
                }

                // Fonction de sauvegarde
                if (input.ToLower() == "save")
                {
                    try
                    {
                        sFile.SaveGridToJson(sudoku.Grid, sudoku.InitialGrid, "sudoku_save.json");
                        error = "Grille sauvegardée.";
                    }
                    catch
                    {
                        error = "Erreur lors de la sauvegarde de la grille.";
                    }
                    break;
                }

                try
                {
                    // Vérifier le format de l'entrée
                    string[] parts = input.Split(' ');
                    if (parts.Length != 2)
                    {
                        Console.WriteLine("Format invalide. Essayez 'A1 5'.");
                        continue;
                    }

                    // Convertir la position et la valeur
                    string rowCol = parts[0];
                    int value = int.Parse(parts[1]);

                    if (rowCol.Length != 2)
                    {
                        Console.WriteLine("Format de position invalide. Essayez 'A1'.");
                        continue;
                    }

                    // Convertir la rangée en index
                    string row = rowCol[0].ToString();
                    int col = int.Parse(rowCol[1].ToString()) - 1; // -1 pour index

                    sudoku.PlayGrid(row, col, value);

                    // Vérifier si la grille est complétée
                    if (validate.IsGameWon(sudoku.Grid))
                    {
                        printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid, true);
                        Console.WriteLine("Bravo! Vous avez résolu la grille. Appuyez sur une touche pour continuer.");
                        Console.ReadKey();
                        printServices.PrintMainMenu();
                        break;
                    }

                    error = null;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
        }
    }
}