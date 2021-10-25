using OdevHafta5GameProject.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.SERVICE
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
        void GetGameByID(int gameID);
        Game GetGameByName(string gameName);
    }
}
