using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sudoku
{
    public class Sudoku
    {
        private Validations validate = new Validations();
        private PrintServices printServices = new PrintServices();

        private int[,] grid;
        private int[,] initialGrid;
        private readonly Random random = new Random();
        private int difficulty = 40; // Nombre de cases à vider pour créer le puzzle

        public Sudoku()
        {
            grid = new int[9,9];
            initialGrid = new int[9, 9];
        }

        public int[,] Grid 
        {
            get { return grid; } 
            set { grid = value; }
        }
        public int[,] InitialGrid
        {
            get { return initialGrid; }
            set { initialGrid = value; }
        }
        public Random Random
        {
            get { return random; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
    }
}
