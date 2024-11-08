using System.Text.Json;

namespace Sudoku
{
    /// Class to store the Sudoku grid and the initial grid --> In a serializable format
    public class SudokuFile
    {
        public int[][] Grid { get; set; }
        public int[][] InitialGrid { get; set; }

        public SudokuFile()
        {
            Grid = new int[9][];
            InitialGrid = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                Grid[i] = new int[9];
                InitialGrid[i] = new int[9];
            }
        }

        /// <summary>Charger la grille de Sudoku depuis un fichier JSON</summary>
        /// <param name="grid">Reçoit la grille de jeu à imprimé contenant les entrées du joueur</param>
        /// <param name="initialGrid">Reçoit la grille d'origine pour différencier la couleur à afficher</param>
        /// <param name="filePath">Chemin du fichier enregistrer</param>
        public bool LoadGridFromJson(int [,] grid, int [,] initialGrid, string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                var jsonGrid = JsonSerializer.Deserialize<SudokuFile>(jsonContent);

                if (jsonGrid != null && jsonGrid.Grid.Length == 9 && jsonGrid.Grid[0].Length == 9)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            grid[i, j] = jsonGrid.Grid[i][j];
                            initialGrid[i, j] = jsonGrid.InitialGrid[i][j];
                        }
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Le fichier JSON n'a pas le bon format.");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier JSON : " + e.Message);
                return false;
            }
        }

        /// <summary>Sauvegarder la grille de Sudoku dans un fichier JSON</summary>
        /// <param name="grid">Reçoit la grille de jeu à imprimé contenant les entrées du joueur</param>
        /// <param name="initialGrid">Reçoit la grille d'origine pour différencier la couleur à afficher</param>
        /// <param name="filePath">Chemin du fichier enregistrer</param>
        public void SaveGridToJson(int[,] grid, int[,] initialGrid, string filePath)
        {
            var jsonGrid = new SudokuFile
            {
                Grid = new int[9][],
                InitialGrid = new int[9][]
            };

            for (int i = 0; i < 9; i++)
            {
                jsonGrid.Grid[i] = new int[9];
                jsonGrid.InitialGrid[i] = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    jsonGrid.Grid[i][j] = grid[i, j];
                    jsonGrid.InitialGrid[i][j] = initialGrid[i, j];
                }
            }

            string jsonContent = JsonSerializer.Serialize(jsonGrid, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonContent);
        }
    }
}