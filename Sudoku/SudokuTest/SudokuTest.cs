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
            Exception expectedExcetpion = null;

            // Act
            try 
            { 
                // Paramètres row ou col ne correspond pas à un début de carré
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
            Exception expectedExcetpion = null;

            // Act
            try
            {
                // Carré déjà remplie avec 1+ valeur(s)
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
            int[,] grid = new int[9, 9];
            int row = 0;
            int col = 0;
            int count = 0;

            // Act

            // Assert
            if (grid[0, 0] != 0) count++;
            if (grid[0, 1] != 0) count++;
            if (grid[0, 2] != 0) count++;
            if (grid[1, 0] != 0) count++;
            if (grid[1, 1] != 0) count++;
            if (grid[1, 2] != 0) count++;
            if (grid[2, 0] != 0) count++;
            if (grid[2, 1] != 0) count++;
            if (grid[2, 2] != 0) count++;
            Assert.AreEqual(count, 9);
        }
    }
}