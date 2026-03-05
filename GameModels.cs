using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morskoibii
{
        public enum GameMode
        {
            VsComputer,
            VsPlayer
        }
        public enum CellState
        {
            Empty,
            Ship,
            Hit,
            Miss
        }
        public enum ShipDirection
        {
            Horizontal,
            Vertical
        }
}
