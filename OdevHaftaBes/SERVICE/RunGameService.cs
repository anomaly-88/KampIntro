using OdevHaftaBes.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.SERVICE
{
    class RunGameService : INTERFACE.IGameService
    {
        public void Set()
        {
            //Oyun yüklü mü kontrolü, isInstalled i çağır
        }
        public void Run()
        {
            //bitince herşey burayı çağır.
        }

        public void isInstalled(LocalGame localGame)
        {
            //isTheGameInstalled?
            //Check The path and file
            // if xyz file exists in the path then execute LoadGame()
            Console.WriteLine("Checking..");
            string path = localGame.InstallPath;
            // if path exist code  .....  TRUE -> then;

            Run(localGame);

        }

        public void Install(LocalGame localGame)
        {
            //LocalGame Install Path..
            Console.WriteLine("Game Installing..");

        }

        public void Run(LocalGame localGame)
        {
            //New game Or LoadGame()
            Console.WriteLine("Loading game..");
        }


    }
}
