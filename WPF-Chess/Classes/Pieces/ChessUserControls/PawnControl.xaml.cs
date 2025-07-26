using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Chess.Structs;

namespace WPF_Chess.Classes.Pieces.ChessUserControls
{
    public partial class PawnControl : UserControl
    {
        private readonly Pawn _pawn;

        public PawnControl(Owner owner, string position)
        {
            InitializeComponent();
            _pawn = new Pawn(owner, position);
            PawnImage.Source = _pawn.Image;
        }
    }
}
