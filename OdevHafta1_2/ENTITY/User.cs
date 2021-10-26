using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.ENTITY
{
    class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public int Authority { get; set; }
        public Dictionary<string, int> UserSettings { get; set; }
        public List<int> Courses { get; set; }
        public List<string> Subscriptions { get; set; }
        public string CreditCard { get; set; }
    }
}
