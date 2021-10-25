using OdevHaftaBes.ENTITY;
using OdevHaftaBes.MANAGER;
using System;
using System.Collections.Generic;

namespace OdevHaftaBes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. 
             * Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
             * (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */
            //Bu game ve user iki farklı obje, elma ile armut. dolayısı ile 


            //choose your game type
            //the game is running..
            List<LocalGame> testGame = new List<LocalGame> { new LocalGame { GameID = 1, GameName = "TEST GAME", GameType = "Local", TypeKeys = new List<string> { "Sport", "Action" }, Version = "1.1", VersionDate = "01.01.2022",InstallPath="C://ProgramFiles/GameName" } };
            foreach (var item in testGame)
            {
                Console.WriteLine(item.GameID.ToString() + "\n" +
                                  item.GameName.ToString() + "\n" +
                                  item.GameType.ToString() + "\n" +
                                  item.InstallPath.ToString() + "\n" +
                                  string.Join(", ",item.TypeKeys) + "\n"+
                                  item.Version.ToString()+ "\n" +
                                  item.VersionDate.ToString());
            }

        }
    }
}
