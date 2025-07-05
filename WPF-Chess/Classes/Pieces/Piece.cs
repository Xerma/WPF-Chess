using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_Chess.Structs;

namespace WPF_Chess.Classes.Pieces
{
    public enum PieceType { Pawn, Knight, Bishop, Rook, Queen, King }

    public enum Owner { P1, P2 }

    public abstract class Piece
    {
        private string _pieceId;
        public string PieceId { get { return _pieceId; } }
        public PieceType Type { get; private set; }
        public Owner Owner { get; private set; }

        private DrawingImage _image;
        public DrawingImage Image { get { return _image; } }

        public SolidColorBrush DisplayColor { get; set; }

        public Piece(PieceType type, Owner owner, int pieceNumber = 1)
        {
            Type = type;
            Owner = owner;
            GeneratePieceID(pieceNumber);
            SetPieceImage(type);
        }

        public bool HasAlreadyMoved { get; set; } = false;
        public abstract Vector2D[] MovementVectors { get; }
        public abstract Vector2D[] AttackVectors { get; }

        private void GeneratePieceID(int pieceNumber)
        {
            _pieceId = $"{Owner}_{Type}_{pieceNumber}";

        }

        private void SetPieceImage(PieceType type)
        {
            switch (type)
            {
                case PieceType.Pawn:
                    _image = (DrawingImage)Application.Current.FindResource("PawnIcon");
                    break;
                case PieceType.Knight:
                    _image = (DrawingImage)Application.Current.FindResource("KnightIcon");
                    break;
                case PieceType.Bishop:
                    _image = (DrawingImage)Application.Current.FindResource("BishopIcon");
                    break;
                case PieceType.Rook:
                    _image = (DrawingImage)Application.Current.FindResource("RookIcon");
                    break;
                case PieceType.Queen:
                    _image = (DrawingImage)Application.Current.FindResource("QueenIcon");
                    break;
                case PieceType.King:
                    _image = (DrawingImage)Application.Current.FindResource("KingIcon");
                    break;
            }
        }
    }
}