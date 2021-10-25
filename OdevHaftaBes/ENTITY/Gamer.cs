using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.ENTITY
{
    class Gamer
    {
        public int GamerID { get; set; }
        public List<LocalGame> Games { get; set; }
        public string Cn { get; set; } //citizenship number
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bdate { get; set; } //Birth Date
       

    }
}
