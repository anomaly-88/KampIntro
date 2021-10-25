using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.MANAGER;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;

namespace OdevHafta5GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameService gameManager = new GameManager();
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            ICampaignService campaignService = new BaseCampaignManager(new List<ICampaignService>{new BlackMondayCampaignManager(), new PatronCildirdiCampaignManager()});
            IMarketService marketManager = new MarketManager(campaignService);

            Game game1 = new Game
            {
                GameID = 1,
                GameName = "Assasins in the world",
                GameKeyword = "Action",
                GameType = "Local",
                ReleaseVersion = "Beta_0.1",
                PathOrIP = "C://ProgramFiles//Games//" };
            Game game2 = new Game
            {
                GameID = 2,
                GameName = "Quake Six",
                GameKeyword = "Action",
                GameType = "Local",
                ReleaseVersion = "Beta_0.7",
                PathOrIP = "C://ProgramFiles//Games//"
            };
            Game game3 = new Game
            {
                GameID = 3,
                GameName = "Conter Strike",
                GameKeyword = "Action",
                GameType = "Remote",
                ReleaseVersion = "Alfa5",
                PathOrIP = "127.0.0.1"
            };


            Gamer gamer = new Gamer
            {
                Id = 1,
                IdentityNumber = "12345",
                FirstName = "So",
                LastName = "Infinity",
                BirthYear = 1990,
                GamerGameList = new List<int> { 1, 3 }
            };

            Order order1 = new Order
            {
                OrderID = 1,
                GameID = 2,
                GamerID = 1,
                OperationType = "Buy",
                Price = 100,
                Quantity = 1,
                Date = "01.01.2022",
                CampaignID = 0
            };

            Order order2 = new Order
            {
                OrderID = 2,
                GameID = 2,
                GamerID = 1,
                OperationType = "Sell",
                Price = 110,
                Quantity = 1,
                Date = "02.01.2022",
                CampaignID = 1
            };

            Order order3 = new Order
            {
                OrderID = 2,
                GameID = 2,
                GamerID = 1,
                OperationType = "Buy",
                Price = 110,
                Quantity = 1,
                Date = "02.01.2022",
                CampaignID = 1
            };





            marketManager.MarketRoute(order3, game2, gamer);
            gamerManager.Add(gamer);
            gamerManager.GetGamerGamesWithNames(gamer, new Game[]{ game1, game2, game3});




            //marketManager.BuyGame(order1, game2, gamer);
            //marketManager.SellGame(order2, game2, gamer);
            //marketManager.BuyGame(order1, game2, gamer);


            //campaignService.CalculateNewPrice(order2);


            //campaignService.CalculateNewPrice(order1);


            //gameManager.Add(game1);
            //gamerManager.GamerGameList(gamer);

            //GamerManager firstTest = new GamerManager();
            //firstTest.Add({ new Gamer<String, int, List<Game>> { Id = 1, IdentityNumber = "12345", FirstName = "So", LastName = "Infinity",
            //BirthYear = 1990, Games = new List<Game> { new Game { GameID = 1, GameName = "Assasins in the world", GameKeyword = "Action", GameType = "Local",
            //ReleaseVersion = "Beta_0.1", PathOrIP = "C://ProgramFiles//Games//" } } });
        }
    }
}
