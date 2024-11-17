using Sudoku;
namespace SudokuTest
{
    [TestClass]
    public class SudokuTest
    {
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

        public void FillDiagonal_Filled()
        {
            Sudoku.Sudoku sudoku = new Sudoku.Sudoku();
            Exception expectedExcetpion = null;

            // Act
            try
            {
                // Remplir les 3 carrés diagonaux
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNull(expectedExcetpion);
        }
    }
}