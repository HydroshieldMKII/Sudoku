using Sudoku;
namespace SudokuTest
{
    [TestClass]
    public class SudokuTest
    {
        [TestMethod]
        public void PlayGrid_InitialValue()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Grid[0, 0] = 5; // Initial value
            sudoku.InitialGrid[0, 0] = 5; // Indiquer que c'est une valeur initiale
            Exception exception = null;

            // Act
            try
            {
                // Essayer de modifier la valeur initiale
                sudoku.PlayGrid("A", 0, 3);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(InvalidOperationException));
            Assert.AreEqual(5, sudoku.Grid[0, 0]); // La valeur reste inchangée
        }

        [TestMethod]
        public void PlayGrid_ValueEntered()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;

            // Act
            try
            {
                // Jouer une valeur valide dans une case vide
                sudoku.PlayGrid("A", 1, 3);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.IsNull(exception);
            Assert.AreEqual(3, sudoku.Grid[0, 1]); // La valeur saisie est correcte
        }

        [TestMethod]
        public void PlayGrid_InvalidPosition()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;

            // Act
            try
            {
                // Essayer de jouer dans une position invalide
                sudoku.PlayGrid("J", 10, 4);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(ArgumentException));
        }


        [TestMethod]
        public void RemoveNumbers_NumbersRemoved40()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;

            try
            {
                sudoku.RemoveNumbers(40);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [TestMethod]
        public void RemoveNumbers_NumbersRemoved50()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;

            try
            {
                sudoku.RemoveNumbers(50);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [TestMethod]
        public void SolveSudoku_PartiallyResolved()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;
            bool solved = false;

            try
            {
                // Compléter la grille de jeu
               sudoku.Grid[0, 0] = 5;
               sudoku.Grid[0, 1] = 3;
               sudoku.Grid[1, 0] = 6;
               solved = sudoku.SolveGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
            Assert.IsTrue(solved);
        }

        [TestMethod]
        public void SolveSudoku_NewGrid()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Difficulty = 40;
            Exception exception = null;
            bool solved = false;

            try
            {
                sudoku.GenerateSudokuGrid();
                solved = sudoku.SolveGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
            Assert.IsTrue(solved);
        }

        [TestMethod]
        public void SolveSudoku_EmptyGrid()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception exception = null;
            bool solved = false;

            try
            {
                solved = sudoku.SolveGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
            Assert.IsTrue(solved);
        }



        [TestMethod]
        public void GenerateSudokuGrid_Difficutly30()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Difficulty = 30;
            Exception exception = null;


            try
            {
                //Generation de la grille ici
                sudoku.GenerateSudokuGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [TestMethod]
        public void GenerateSudokuGrid_Difficutly40()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Difficulty = 40;
            Exception exception = null;

            try
            {
                //Generation de la grille ici
                sudoku.GenerateSudokuGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [TestMethod]
        public void GenerateSudokuGrid_Difficutly50()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Difficulty = 50;
            Exception exception = null;

            try
            {
                //Generation de la grille ici
                sudoku.GenerateSudokuGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        [TestMethod]
        public void GenerateSudokuGrid_Difficutly60()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Difficulty = 60;
            Exception exception = null;

            try
            {
                //Generation de la grille ici
                sudoku.GenerateSudokuGrid();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNull(exception);
        }

        /// ================= FillBox =================
        [TestMethod]
        public void FillBox_ValidParamsFalse()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception expectedExcetpion = null;

            // Act
            try 
            { 
                // Paramètres row ou col ne correspond pas à un début de carré
                sudoku.FillBox(sudoku.Grid, 1, 2);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void FillBox_NotEmpty()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            sudoku.Grid[0, 0] = 1;
            Exception expectedExcetpion = null;

            // Act
            try
            {
                // Carré déjà remplie avec 1+ valeur(s)
                sudoku.FillBox(sudoku.Grid, 0, 0);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void FillBox_Filled()
        {
            // Arrange
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception expectedExcetpion = null;

            // Act
            try
            {
                sudoku.FillBox(sudoku.Grid, 0, 0);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNull(expectedExcetpion);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreNotEqual(0, sudoku.Grid[i, j]);
                }
            }
        }

        [TestMethod]
        public void FillDiagonal_Filled()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception expectedExcetpion = null;

            // Act
            try
            {
                // Remplir les 3 carrés diagonaux
                sudoku.FillDiagonal();
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNull(expectedExcetpion);

            // Vérifier que les 3 carrés diagonaux sont remplis
            for (int i = 0; i < 9; i += 3)
            {
                Assert.AreEqual(1, sudoku.Grid[i, i]);
            }
        }
    }
}