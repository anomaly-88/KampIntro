using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class BlackMondayCampaignManager : ICampaignService
    {
        public int CampaignId = 1;
        public string CampaignName = "BlackMonday";



        public double SetCampaignRate()
        {
            return 0.12;
        }

        public int GetCampaignId()
        {
            return CampaignId;
        }

        public string GetCampaignName()
        {
            return CampaignName;
        }

        public double CalculateNewPrice(Order order)
        {
            return 0;
        }


    }
}
