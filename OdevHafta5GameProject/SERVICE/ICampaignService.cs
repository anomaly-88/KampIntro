using OdevHafta5GameProject.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.SERVICE
{
    interface ICampaignService
    {
        double SetCampaignRate();
        double CalculateNewPrice(Order order);
        int GetCampaignId();
        string GetCampaignName();
    }
}
