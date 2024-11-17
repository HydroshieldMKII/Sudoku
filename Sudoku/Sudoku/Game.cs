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
                        sudoku.GenerateGrid();
                        sudoku.InitialGrid = sudoku.Grid.Clone() as int[,];
                        printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
                        break;
                    case "2":
                        sudoku.Grid = sFile.LoadGrid();
                        sudoku.InitialGrid = sudoku.Grid.Clone() as int[,];
                        printServices.PrintGrid(sudoku.Grid, sudoku.InitialGrid);
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
}