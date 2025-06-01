using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WPF_Chess.Classes.Pieces;

namespace WPF_Chess.Classes.Managers
{
    internal class PieceManager
    {
        private Piece[] CreatePawnSet(Owner owner)
        {
            Piece[] pawns = new Piece[8];

            for (int i = 0; i < 8; i++)
            {
                pawns[i] = new Pawn(owner, i + 1);
            }

            return pawns;
        }

        private Piece[] CreateRearSet(Owner owner)
        {
            Rook rook1 = new(owner, 1);
            Knight knight1 = new(owner, 1);
            Bishop bishop1 = new(owner, 1);
            Queen queen = new(owner, 1);
            King king = new(owner, 1);
            Bishop bishop2 = new(owner, 2);
            Knight knight2 = new(owner, 2);
            Rook rook = new(owner, 2);

            Piece[] rearSet = [rook1, knight1, bishop1, queen, king, bishop2, knight2, rook];

            return rearSet;
        }

        public Piece[,] CreateFullSet(Owner owner)
        {
            Piece[,] PlayerSet = new Piece[2, 8];
            Piece[] Pawns = CreatePawnSet(owner);
            Piece[] RearSet = CreateRearSet(owner);

            switch (owner)
            {
                case Owner.P1:
                    for (int i = 0; i < 8; i++)
                    {
                        PlayerSet[0, i] = Pawns[i];
                        PlayerSet[1, i] = RearSet[i];
                    }

                    foreach (var piece in PlayerSet)
                    {
                        piece.DisplayColor = (SolidColorBrush)Application.Current.FindResource("P1_Color");
                    }

                    break;
                case Owner.P2:
                    for (int i = 0; i < 8; i++)
                    {
                        PlayerSet[0, i] = RearSet[i];
                        PlayerSet[1, i] = Pawns[i];
                    }

                    foreach (var piece in PlayerSet)
                    {
                        piece.DisplayColor = (SolidColorBrush)Application.Current.FindResource("P2_Color");
                    }

                    break;
            }

            return PlayerSet;
        }
    }
}
