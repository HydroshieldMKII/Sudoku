namespace SudokuTest
{
    [TestClass]
    public class ValidationsTest
    {
        /// ================= IsSafe =================
        [TestMethod]
        public void IsSafe_FalseIfNumInLine()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1; 
            bool result;

            // Act
            // Essayer de placer dans grid[1, 7] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSafe_FalseIfNumInCol()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1; 
            bool result;

            // Act
            // Essayer de placer dans grid[7, 1] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSafe_FalseIfNumInBox()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1; 
            bool result;

            // Act
            // Essayer de placer dans grid[2, 1] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSafe_TrueIfNumIsSafe()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1; 
            bool result;

            // Act
            // Essayer de placer dans grid[4, 4] = 1; Dans une grille vide
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        /// ================= IsSaved =================
        [TestMethod]
        public void IsValid_FalseIfNumInLine()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1;
            bool result;

            // Act
            // Essayer de placer dans grid[1, 7] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_FalseIfNumInCol()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1;
            bool result;

            // Act
            // Essayer de placer dans grid[7, 1] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_FalseIfNumInBox()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1;
            bool result;

            // Act
            // Essayer de placer dans grid[2, 1] = 1;
            result = true;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_TrueIfNumIsSafe()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            grid[1, 1] = 1;
            bool result;

            // Act
            // Essayer de placer dans grid[4, 4] = 1; Dans une grille vide
            result = true;

            // Assert
            Assert.IsFalse(result);
        }
    }
}