using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public PieceType Type { get; private set; }
        public Owner Owner { get; private set; }
        public abstract string Position { get; set; }
        public DrawingImage Image { get; private set; }

        protected Piece(PieceType type, Owner owner, string position)
        {
            Type = type;
            Owner = owner;
            Position = position;
            DrawingImage baseImage = SetPieceImage(type);
            Image = UpdateDrawingColor(owner, baseImage);
        }

        public bool HasAlreadyMoved { get; set; } = false;
        public abstract Vector2D[] MovementVectors { get; set; }
        public abstract Vector2D[] AttackVectors { get; set; }

        private static DrawingImage SetPieceImage(PieceType type)
        {
            switch (type)
            {
                case PieceType.Pawn:
                    return (DrawingImage)Application.Current.TryFindResource("PawnIcon");
                case PieceType.Knight:
                    return (DrawingImage)Application.Current.TryFindResource("KnightIcon");
                case PieceType.Bishop:
                    return (DrawingImage)Application.Current.TryFindResource("BishopIcon");
                case PieceType.Rook:
                    return (DrawingImage)Application.Current.TryFindResource("RookIcon");
                case PieceType.Queen:
                    return (DrawingImage)Application.Current.TryFindResource("QueenIcon");
                case PieceType.King:
                    return (DrawingImage)Application.Current.TryFindResource("KingIcon");
                default:
                    Debug.WriteLine("Warning: Icon not found.");
                    throw new ArgumentOutOfRangeException(nameof(type), $"Unsupported piece type: {type}");
            }
        }

        private DrawingImage UpdateDrawingColor(Owner owner, DrawingImage original)
        {
            SolidColorBrush fill = Brushes.Gray;

            switch (owner)
            {
                case Owner.P1:
                    fill = (SolidColorBrush)Application.Current.TryFindResource("P1Color");
                    
                    break;
                case Owner.P2:
                    fill = (SolidColorBrush)Application.Current.TryFindResource("P2Color");
                    break;
            }

            if (original.Drawing is GeometryDrawing geometry)
            {
                GeometryDrawing newDrawing = new GeometryDrawing
                {
                    Geometry = geometry.Geometry.Clone(),
                    Brush = fill,
                    Pen = geometry.Pen
                };

                return new DrawingImage(newDrawing);
            }

            return original;
        }
    }
}