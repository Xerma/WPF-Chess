using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WPF_Chess.Structs;

namespace WPF_Chess.Classes.Pieces
{
    internal class Pawn : Piece
    {
        private readonly Vector2D[] _pawnMoves;
        public override Vector2D[] MovementVectors => _pawnMoves;

        private readonly Vector2D[] _pawnAttacks;
        public override Vector2D[] AttackVectors => _pawnAttacks;

        public Pawn(Owner owner, int number) : base(PieceType.Pawn, owner, number)
        {
            switch (owner)
            {
                case Owner.P2: // TOP
                    _pawnMoves = [new(0, -1)];
                    _pawnAttacks = [new(-1, -1), new(1, -1)];
                    break;
                case Owner.P1: // BOTTOM
                    _pawnMoves = [new(0, 1)];
                    _pawnAttacks = [new(-1, 1), new(1, 1)];
                    break;
                default:
                    throw new ArgumentException("Unknown owner", nameof(owner));
            }
        }
    }
}
