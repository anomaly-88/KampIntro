using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.ENTITY
{
    class Order
    {
        public int OrderID { get; set; }
        public int GamerID { get; set; }
        public int GameID { get; set; }
        public string OperationType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
        public int CampaignID { get; set; }
    }
}
