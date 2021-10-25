using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class PatronCildirdiCampaignManager : ICampaignService
    {
        public int CampaignId = 2;
        public string CampaignName = "PatronCildirdi";



        public double SetCampaignRate()
        {

            return 0.10;
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
