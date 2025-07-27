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
        public override Vector2D[] MovementVectors { get; set; }
        public override Vector2D[] AttackVectors { get; set; }
        public override string Position { get; set; }

        private readonly Vector2D[] _pawnAttacks;
        public override Vector2D[] AttackVectors => _pawnAttacks;

        private string _currentPosition;
        public override string CurrentPosition
        {
            get { return _currentPosition; }
            set { _currentPosition = value; }
        }

        public Pawn(Owner owner, string cp) : base(PieceType.Pawn, owner, cp)
        {
            switch (owner)
            {
                case Owner.P2: // TOP
                    MovementVectors = 
                        [
                            new(0, -1)
                        ];
                    AttackVectors = 
                        [
                            new(-1, -1),
                            new(1, -1)
                        ];
                    break;
                case Owner.P1: // BOTTOM
                    MovementVectors = 
                        [
                            new(0, 1)
                        ];
                    AttackVectors = 
                        [
                            new(-1, 1),
                            new(1, 1)
                        ];
                    break;
                default:
                    throw new ArgumentException("Unknown owner", nameof(owner));
            }

            Position = cp;
        }
    }
}
