using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Chess.Classes.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(Owner owner, int number) : base(PieceType.Pawn, owner, number)
        {
            AttackRangeDiagonal = 1;

            if (owner == Owner.P2) // top
            {
                MoveRangeDown = 1;
                CanAttackDown = true;
            }
            if (owner == Owner.P1) // bottom
            {
                MoveRangeUp = 1;
                CanAttackUp = true;
            }
            
        }
    }
}
