using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF_Chess.Classes.Pieces;
using WPF_Chess.Structs;
using static WPF_Chess.Classes.Pieces.Piece;
using WPF_Chess.Classes.Pieces.ChessUserControls;

namespace WPF_Chess.Classes.Managers
{
    internal class BoardManager
    {
        private readonly MainWindow _mainWindow;

        // PLAYER 2
        private readonly PawnControl P2_Pawn1;
        private readonly PawnControl P2_Pawn2;
        private readonly PawnControl P2_Pawn3;
        private readonly PawnControl P2_Pawn4;
        private readonly PawnControl P2_Pawn5;
        private readonly PawnControl P2_Pawn6;
        private readonly PawnControl P2_Pawn7;
        private readonly PawnControl P2_Pawn8;

        // PLAYER 1
        private readonly PawnControl P1_Pawn1;
        private readonly PawnControl P1_Pawn2;
        private readonly PawnControl P1_Pawn3;
        private readonly PawnControl P1_Pawn4;
        private readonly PawnControl P1_Pawn5;
        private readonly PawnControl P1_Pawn6;
        private readonly PawnControl P1_Pawn7;
        private readonly PawnControl P1_Pawn8;

        public BoardManager(MainWindow window)
        {
            _mainWindow = window;

            P2_Pawn1 = new PawnControl(Owner.P2, _mainWindow.A7.Name);
            P2_Pawn2 = new PawnControl(Owner.P2, _mainWindow.B7.Name);
            P2_Pawn3 = new PawnControl(Owner.P2, _mainWindow.C7.Name);
            P2_Pawn4 = new PawnControl(Owner.P2, _mainWindow.D7.Name);
            P2_Pawn5 = new PawnControl(Owner.P2, _mainWindow.E7.Name);
            P2_Pawn6 = new PawnControl(Owner.P2, _mainWindow.F7.Name);
            P2_Pawn7 = new PawnControl(Owner.P2, _mainWindow.G7.Name);
            P2_Pawn8 = new PawnControl(Owner.P2, _mainWindow.H7.Name);

            P1_Pawn1 = new PawnControl(Owner.P1, _mainWindow.A2.Name);
            P1_Pawn2 = new PawnControl(Owner.P1, _mainWindow.B2.Name);
            P1_Pawn3 = new PawnControl(Owner.P1, _mainWindow.C2.Name);
            P1_Pawn4 = new PawnControl(Owner.P1, _mainWindow.D2.Name);
            P1_Pawn5 = new PawnControl(Owner.P1, _mainWindow.E2.Name);
            P1_Pawn6 = new PawnControl(Owner.P1, _mainWindow.F2.Name);
            P1_Pawn7 = new PawnControl(Owner.P1, _mainWindow.G2.Name);
            P1_Pawn8 = new PawnControl(Owner.P1, _mainWindow.H2.Name);

            NewBoard();
        }

        public void NewBoard()
        {
            SetPawns();
        }

        public void HighlightMovements()
        {

        }

        public void HighlightAttacks()
        {

        }

        public void MovePieceTo(UserControl control, string newLocation)
        {

        }

        public void AddPieceAt(UserControl control, string location)
        {

        }

        public void RemovePieceAt(UserControl control)
        {
            //_mainWindow.FindName(control.posi)
        }

        public bool PieceExistsAt(string location)
        {
            return false;
        }

        public string ApplyVector(string boardLocation, Vector2D moveVector)
        {
            Vector2D boardLocationToVector2D = Vector2D.ToBoardGrid(boardLocation);
            int appliedX = boardLocationToVector2D.X + moveVector.X;
            int appliedY = boardLocationToVector2D.Y + moveVector.Y;
            Vector2D newVector = new Vector2D(appliedX, appliedY);
            return newVector.ToBoardString();
        }

        private void SetPawns()
        {
            _mainWindow.A7.Child = P2_Pawn1;
            _mainWindow.B7.Child = P2_Pawn2;
            _mainWindow.C7.Child = P2_Pawn3;
            _mainWindow.D7.Child = P2_Pawn4;
            _mainWindow.E7.Child = P2_Pawn5;
            _mainWindow.F7.Child = P2_Pawn6;
            _mainWindow.G7.Child = P2_Pawn7;
            _mainWindow.H7.Child = P2_Pawn8;

            _mainWindow.A2.Child = P1_Pawn1;
            _mainWindow.B2.Child = P1_Pawn2;
            _mainWindow.C2.Child = P1_Pawn3;
            _mainWindow.D2.Child = P1_Pawn4;
            _mainWindow.E2.Child = P1_Pawn5;
            _mainWindow.F2.Child = P1_Pawn6;
            _mainWindow.G2.Child = P1_Pawn7;
            _mainWindow.H2.Child = P1_Pawn8;
        }
    }
}
