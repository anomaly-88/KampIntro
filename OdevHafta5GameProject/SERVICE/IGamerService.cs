using OdevHafta5GameProject.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.SERVICE
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        List<int> GamerGameList(Gamer gamer);
        public String GetGamerGamesWithNames(Gamer gamer, Game[] games);
       


    }
}
