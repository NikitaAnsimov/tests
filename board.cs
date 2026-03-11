using morskoibii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Board
    {
        public const int Size = 10;
        public CellState[,] Grid { get; private set; } = new CellState [Size, Size];
        public List<Ship> Ships { get; private set; } = new List<Ship>();
        public void Reset()
        {
            Grid = new CellState[Size, Size];
            Ships.Clear();
        }
    }
}
