using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.ENTITY
{
    class Gamer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public List<int> GamerGameList { get; set; }
    }
}
