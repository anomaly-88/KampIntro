using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class MarketManager : IMarketService
    {

        ICampaignService _campaignService;

        public MarketManager(ICampaignService campaignService)
        {
            this._campaignService = campaignService;
        }


        public void MarketRoute(Order order, Game game, Gamer gamer)
        {
            if (order.OperationType.Contains("Buy"))
            {
                BuyGame(order, game, gamer);
            }
            else if (order.OperationType.Contains("Sell"))
            {
                SellGame(order, game, gamer);
            }
        }

        public int BuyGame(Order order, Game game, Gamer gamer)
        {

            
            gamer.GamerGameList.Add(order.GameID);

            Console.WriteLine(
            "\n##### "+order.OperationType+" #####"+
            "\nCustomer: "+
            gamer.FirstName +
            " "+
            gamer.LastName+
            "\nGame: "+
            game.GameName+
            "\nOperationID: "+
            order.OrderID+
            "\n  [Success]");

            _campaignService.CalculateNewPrice(order);

            //foreach (var gamerGame in gamer.GamerGameList) { Console.WriteLine(gamerGame + " After the kiss"); }

            return game.GameID;
        }

        public int SellGame(Order order, Game game, Gamer gamer)
        {

            gamer.GamerGameList.Remove(order.GameID);

            Console.WriteLine(
            "\n##### "+order.OperationType+" #####"+
            "\nCustomer: "+
            gamer.FirstName +
            " "+
            gamer.LastName+
            "\nGame: "+
            game.GameName+
            "\nOperationID: "+
            order.OrderID+
            "\n  [Success]\n");


            //foreach (var gamerGame in gamer.GamerGameList) { Console.WriteLine(gamerGame + " After the kiss"); }
            
            return game.GameID;
        }

    }
}
