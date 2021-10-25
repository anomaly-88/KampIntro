using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.ENTITY
{
    class RemoteGame:Game
    {
        public string SrvConnString { get; set; } //Server Connection String
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }

        /*
         * 
         * config etc.
         */
    }
}
