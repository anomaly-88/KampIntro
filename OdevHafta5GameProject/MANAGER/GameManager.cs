using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("GameManager Add OP.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("GameManager Delete OP.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("GameManager Update OP.");
        }

        public void GetGameByID(int gameID)
        {
            
            Console.WriteLine("GameManager GetGameById OP."+" this id = " + gameID);

        }

        public Game GetGameByName(string gameName)
        {
            Console.WriteLine("GameManager GetGameByName OP.");
            return null;
        }

        //public void GetListOfGames(List<int> game)
        //{
        //    Console.WriteLine(game.Count); 
        //}

    }
}
