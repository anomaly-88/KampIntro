using OdevHaftaBes.ENTITY;
using OdevHaftaBes.INTERFACE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.MANAGER
{
    class GameManager
    {

        //LocalGame localGame;
        //RemoteGame RemoteGame;
        Game game;
        LocalGame localGame;
        RemoteGame remoteGame;

        public GameManager(Game game)
        {
            this.game = game;
            Console.WriteLine("Executing Game Scenario");
        }

        public GameManager(LocalGame localGame )
        {
            this.localGame = localGame;
            Console.WriteLine("Executing LocalGame Scenario");
        }

        public GameManager(RemoteGame remoteGame)
        {
            this.remoteGame = remoteGame;
            Console.WriteLine("Executing RemoteGame Scenario");
        }

        public void Verify(IGameService gameService)
        {
            gameService.Set();
        }

   

    }
}
