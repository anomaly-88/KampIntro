using OdevHaftaBes.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.SERVICE
{
    class Conn2RemoteGameService : INTERFACE.IGameService
    {
        RemoteGame remoteGame;
        public Conn2RemoteGameService(RemoteGame remoteGame)
        {
            this.remoteGame = remoteGame;
            Set();
        }

        public void Set()
        {
            //VerifyGameType
           if (this.remoteGame.GameType.Equals("Remote"))
            {
                Connect(this.remoteGame);
                Console.WriteLine("Connecting..");
            }
            else { Console.WriteLine("error"); }
        
        }

        public void Connect(RemoteGame remoteGame)
        {
            //Connect via SrvConnString..
            Console.WriteLine("Connecting..");
            // if - Else .. -> then;
            Console.WriteLine("Success!");
            Run();
        }

        public void Run()
        {
            Console.WriteLine("Starting..");
            for (int i = 5; i>=0 ; i--)
            {
                Console.WriteLine(i+"...");
            }
        }
    }
}
