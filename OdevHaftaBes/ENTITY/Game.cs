using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.ENTITY
{
    class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public List<string> TypeKeys { get; set; } //#Single Player, #RPG..
        public string Version { get; set; }
        public string VersionDate { get; set; }
        public string GameType { get; set; }
    }
}
