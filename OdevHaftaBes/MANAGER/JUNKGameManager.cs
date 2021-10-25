using OdevHaftaBes.ENTITY;
using OdevHaftaBes.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.MANAGER
{
    class JUNKGameManager
    {
        List<Game> game;
        List<Game> localGames = new List<Game>();
        List<Game> remoteGames = new List<Game>();
        LocalGame localGame;
        RemoteGame remoteGame;


        public JUNKGameManager(List<Game> game)
        {
            this.game = game;
            DetectGameType(this.game);
        }

        public void DetectGameType(List<Game> games)
        {

            foreach (var game in games)
            {
                if (game.GameType.Length > 0)
                {
                    foreach (var gameText in game.GameType)
                    {
                        if (gameText.Equals("Local"))
                        {
                            this.localGames.Add(game);
                        }
                        if (gameText.Equals("Remote"))
                        {
                            this.remoteGames.Add(game);
                        }
                    }

                    ChooseGame(this.localGames, this.remoteGames);
                }
            }

        }



        public void ChooseGame(List<Game> localGames, List<Game> remoteGames)
        {

            //What do you want?
            //1 Local | 2 Remote
            // #if select 1 -> Show List of LocalGames 
            // #if select 2 -> Show List of RemoteGames
            //Select a game
            //1..9 -> #Selected
            //than i'm executing the game.

            Console.WriteLine("Please Select a Game Type\n1-Local\n2-Remote");
            string userInputSelectType = Console.ReadLine();
            userInputSelectType = userInputSelectType.ToLower().Trim();
            
            if(userInputSelectType.Contains("local") || userInputSelectType.Contains("1"))
            {
                {
                    Console.WriteLine("Local Game List Loading               and Executing..");
                    if(localGames.Count > 0)
                    {
                        int i = 0;
                        foreach (var localGame in localGames)
                        {
                            i += 1;
                            Console.WriteLine(i+") "+localGame.GameName);
                        }
                        Console.WriteLine("Please select a game with a number:");
                         string userInputSelectGame = Console.ReadLine();
                        // string grappedGameNumber = userInputSelectGame.Trim();
                        //int grappedGameNumberToInt = Convert.ToInt32(grappedGameNumber);
                        //int grappedGameNumberToindexNumber = grappedGameNumberToInt-1;
                        
                    }
                }
            }
            if (userInputSelectType.Contains("remote") || userInputSelectType.Contains("2"))
            {
                {
                    Console.WriteLine("Remote Game Loading and Executing..");
                }
            }

        }


        



        //loading
        public void ExecLocal()
        {
            new RunGameService(this.localGame);
        }

        public void ExecRemote()
        {
            new Conn2RemoteGameService(this.remoteGame);
        }


    }

}







