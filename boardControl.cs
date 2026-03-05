using morskoibii;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public class boardControl : Panel
    {
        private const int CellSize = 40;
        private const int HeaderSize = 25;

        public board board { get; set; } = new board();
        public bool ShowShips { get; set; } = true;
        public bool IsInteractive { get; set; } = false;
        public bool IsSetapMode { get; set; } = false;
        public int PreviewShipSize { get; set; } = 0;
        public ShipDirection PreviewDir { get; set; } = ShipDirection.Horizontal;
        private Point previewCell = new Point(-1, -1);

        public event EventHandler<EventArgs> CellClicked;
        public event EventHandler<EventArgs> CellHovered;

        private static readonly Color ColorWater = Color.FromArgb(20, 60, 120);
        private static readonly Color ColorShip = Color.FromArgb(138, 224, 117);
        private static readonly Color ColorGrid = Color.FromArgb(40, 100, 180);
        private static readonly Color ColorHit = Color.FromArgb(140, 0, 26);
        private static readonly Color ColorMiss = Color.FromArgb(14, 182, 194);
        private static readonly Color ColorSunk = Color.FromArgb(168, 10, 10);
        private static readonly Color ColorPreviewOK = Color.FromArgb(36, 209, 41);
        private static readonly Color ColorPreviewNOOK = Color.FromArgb(255, 8, 8);

        public boardControl()
        {
            int totalSize = CellSize * board.Size + HeaderSize;
            this.Size = new Size ( totalSize, totalSize );
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Default;

        }
        private Point PixelToCell(int X, int Y)
        {
            int col = (X - HeaderSize) / CellSize;
            int row = (Y - HeaderSize) / CellSize;
            return new Point ( row, col ); 
        }
    }
}
