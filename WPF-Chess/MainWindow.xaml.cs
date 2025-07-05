using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Chess.Classes.Managers;

namespace WPF_Chess
{
    //Rows == 1 - 8
    //Columns == A - H

    //row  [0, 1, 2, 3, 4, 5, 6, 7]
    //col  [A, B, C, D, E, F, G, H]

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GameManager gameManager = new GameManager();
        }
    }
}