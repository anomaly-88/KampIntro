using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;
        

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
           

        }

        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("\n#GamerManager Add OP.: User validation success!");
            }
            else { Console.WriteLine("\n#GamerManager Add OP.: You know nothing jon snow"); }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("GamerManager Delete OP.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("GamerManager Update OP.");
        }



        public String GetGamerGamesWithNames(Gamer gamer, Game[] games)
        {
            Console.WriteLine("\n### GetGamerGameName Operation Has Been Started..###");
            //List<int> gamerGameList = GamerGameList(gamer);

            List<int> gamerGameList = gamer.GamerGameList;

            Console.WriteLine("[Gamer " + gamer.FirstName + " " + gamer.LastName + " owns]");

            foreach (var id in gamerGameList)
            {
                foreach (var game in games)
                {
                    if (game.GameID.Equals(id))
                    {
                        Console.WriteLine(game.GameName);
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            Console.WriteLine("[Games.]");
            return null;
        }


        //Junk
        public List<int> GamerGameList(Gamer gamer)
        {
            //foreach (var item in gamer.GamerGameList)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("Executing: Gamer Game List");
            return gamer.GamerGameList;
        }

    }
}
