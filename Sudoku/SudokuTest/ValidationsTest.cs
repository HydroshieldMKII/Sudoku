using Sudoku;
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
            Validations validation = new Validations();
            result = validation.IsSafe(grid, 1, 7, 1);

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
            Validations validation = new Validations();
            result = validation.IsSafe(grid, 7, 1, 1);

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
            Validations validation = new Validations();
            result = validation.IsSafe(grid, 2, 1, 1);

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
            Validations validation = new Validations();
            result = validation.IsSafe(grid, 4, 4, 1);

            // Assert
            Assert.IsTrue(result);
        }


        // IsValid

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
            Validations validation = new Validations();
            grid[1, 7] = 1;
            result = validation.IsValid(grid, 1, 7);

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
            Validations validation = new Validations();
            grid[7, 1] = 1;
            result = validation.IsValid(grid, 7, 1);

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
            Validations validation = new Validations();
            grid[2, 1] = 1;
            result = validation.IsValid(grid, 2, 1);

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
            Validations validations = new Validations();
            grid[4, 4] = 1;
            result = validations.IsValid(grid, 4, 4);

            // Assert
            Assert.IsTrue(result);
        }
    }
}