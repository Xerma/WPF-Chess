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
        //board controller detects piece type and changes tile image and owner overlay (rectangle in user control)
        private MainWindow _mainWindow;

        public BoardManager(MainWindow window)
        {
            _mainWindow = window;
            NewBoard();
        }

        public void NewBoard()
        {
            SetPawns();
        }

        private void SetPawns()
        {
            _mainWindow.A7.Child = new PawnControl(Owner.P2, _mainWindow.A7.Name);
            _mainWindow.B7.Child = new PawnControl(Owner.P2, _mainWindow.B7.Name);
            _mainWindow.C7.Child = new PawnControl(Owner.P2, _mainWindow.C7.Name);
            _mainWindow.D7.Child = new PawnControl(Owner.P2, _mainWindow.D7.Name);
            _mainWindow.E7.Child = new PawnControl(Owner.P2, _mainWindow.E7.Name);
            _mainWindow.F7.Child = new PawnControl(Owner.P2, _mainWindow.F7.Name);
            _mainWindow.G7.Child = new PawnControl(Owner.P2, _mainWindow.G7.Name);
            _mainWindow.H7.Child = new PawnControl(Owner.P2, _mainWindow.H7.Name);

            _mainWindow.A2.Child = new PawnControl(Owner.P1, _mainWindow.A2.Name);
            _mainWindow.B2.Child = new PawnControl(Owner.P1, _mainWindow.B2.Name);
            _mainWindow.C2.Child = new PawnControl(Owner.P1, _mainWindow.C2.Name);
            _mainWindow.D2.Child = new PawnControl(Owner.P1, _mainWindow.D2.Name);
            _mainWindow.E2.Child = new PawnControl(Owner.P1, _mainWindow.E2.Name);
            _mainWindow.F2.Child = new PawnControl(Owner.P1, _mainWindow.F2.Name);
            _mainWindow.G2.Child = new PawnControl(Owner.P1, _mainWindow.G2.Name);
            _mainWindow.H2.Child = new PawnControl(Owner.P1, _mainWindow.H2.Name);
        }
    }
}
