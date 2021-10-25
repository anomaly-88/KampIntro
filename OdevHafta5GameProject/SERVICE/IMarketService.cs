using OdevHafta5GameProject.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.SERVICE
{
    interface IMarketService
    {
        int BuyGame(Order order, Game game, Gamer gamer);
        int SellGame(Order order, Game game, Gamer gamer);
        void MarketRoute(Order order, Game game, Gamer gamer);
    }
}
