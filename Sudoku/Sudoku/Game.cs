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
        }
    }
}