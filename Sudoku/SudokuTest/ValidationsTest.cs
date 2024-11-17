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

        [TestMethod]
        public void IsGameWon_FalseGridNotFull()
        {
            // Arrange
            int[,] grid = new int[9, 9];
            Validations validation = new Validations();
            bool result;

            // Act
            result = validation.IsGameWon(grid);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsGameWon_FalseCellNotValid()
        {
            // Arrange
            int[,] grid = new int[9, 9]
            {
                {5, 3, 0, 0, 7, 0, 0, 0, 0},
                {6, 0, 0, 1, 9, 5, 0, 0, 0},
                {0, 9, 8, 0, 0, 0, 0, 6, 0},
                {8, 0, 0, 0, 6, 0, 0, 0, 3},
                {4, 0, 0, 8, 0, 3, 0, 0, 1},
                {7, 0, 0, 0, 2, 0, 0, 0, 6},
                {0, 6, 0, 0, 0, 0, 2, 8, 0},
                {0, 0, 0, 4, 1, 9, 0, 0, 5},
                {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };
            Validations validation = new Validations();
            bool result;

            // Act
            result = validation.IsGameWon(grid);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsGameWon_TrueGridCompleted()
        {
            // Arrange
            int[,] grid = new int[9, 9]
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 2, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 9}
            };
            Validations validation = new Validations();
            bool result;

            // Act
            result = validation.IsGameWon(grid);

            // Assert
            Assert.IsTrue(result);
        }
    }
}