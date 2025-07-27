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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GameManager gameManager = new(this);
            BoardManager boardManager = new(this);
        }
    }
}