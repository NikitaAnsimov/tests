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

        public Board board { get; set; } = new Board();
        public bool ShowShips { get; set; } = true;
        public bool IsInteractive { get; set; } = false;
        public bool IsSetapMode { get; set; } = false;
        public int PreviewShipSize { get; set; } = 0;
        public ShipDirection PreviewDir { get; set; } = ShipDirection.Horizontal;
        private Point previewCell = new Point(-1, -1);

        public event Action<object, Point> CellClicked;
        public event Action<object, Point> CellHovered;

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
            int totalSize = CellSize * Board.Size + HeaderSize;
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
        private Point CellToPixel(int row, int col)
        {
            return new Point(col * CellSize + HeaderSize, row * CellSize + HeaderSize);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (!IsInteractive) return;
            var cell = PixelToCell(e.X, e.Y);
            if (cell.X < 0 || cell.X > Board.Size || cell.Y < 0 || cell.Y > Board.Size)
                return;

            CellClicked?.Invoke(this, cell);
            
        }
    }
}
