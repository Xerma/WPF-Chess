using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Classes.Managers
{
    internal class GameManager
    {
        public GameManager(MainWindow window)
        {
            BoardManager boardManager = new(window);
        }

        public void NewGame_Singleplayer()
        {
            PlayerManager playerManager = new PlayerManager();
        }

        public void NewGame_LocalMultiplayer()
        {

        }

        public void NewGame_NetworkMultiplayer()
        {

        }
    }
}
