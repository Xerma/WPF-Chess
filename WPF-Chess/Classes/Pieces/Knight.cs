using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Chess.Classes.Pieces
{
    internal class Knight : Piece
    {
        public Knight(Owner owner, int number) : base(PieceType.Pawn, owner, number)
        {

        }
    }
}
