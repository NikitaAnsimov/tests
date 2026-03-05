using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace morskoibii
{
    public class Ship
    {
        public List<Point> Cells {  get; set; } = new List<Point>();
        public int Size { get; set; }
        public bool IsPlaced { get; set; } = false;

        public bool IsSunk(CellState[,] grid)
        {
            foreach(var cell in Cells)
            {
                if (grid[cell.X, cell.Y] != CellState.Hit)
                    return false;
            }
            return true;
        }
    }
}
