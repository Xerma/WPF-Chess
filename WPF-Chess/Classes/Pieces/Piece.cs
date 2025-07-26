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
        public PieceType Type { get; private set; }
        public Owner Owner { get; private set; }
        public abstract string CurrentPosition { get; set; }

        private DrawingImage _image;
        public DrawingImage Image { get { return _image; } }

        protected Piece(PieceType type, Owner owner, string currentPosition)
        {
            Type = type;
            Owner = owner;
            CurrentPosition = currentPosition;
            SetPieceImage(type);
            _image = UpdateDrawingColor(owner, Image);
        }

        public bool HasAlreadyMoved { get; set; } = false;
        public abstract Vector2D[] MovementVectors { get; }
        public abstract Vector2D[] AttackVectors { get; }

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