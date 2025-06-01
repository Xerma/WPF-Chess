using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Chess.Classes.Pieces;
using static WPF_Chess.Classes.Pieces.Piece;

namespace WPF_Chess.Classes.Managers
{
    internal class BoardManager
    {
        //board controller detects piece type and changes tile image and owner overlay (rectangle in user control)

        public static void NewBoard()
        {
            Piece[,] board =
            {
                // 8x8
                {},
                {},
                {},
                {},
                {},
                {},
                {}
            };

            //first = row (nums 1 - 8)
            //second = column (letters A - H)
            //0 = row 8 (top)

        }
    }
}
