using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class BaseCampaignManager : ICampaignService
    {
        double _CampaignRate = 0;
        int _CampaignID = 0;
        string _CampaignName = "";

        List<ICampaignService> _CampaignManagers;


        public BaseCampaignManager(List<ICampaignService> campaignManagers)
        {
            _CampaignManagers = campaignManagers;
        }

        public double CalculateNewPrice(Order order)
        {


            foreach (var campaign in _CampaignManagers)
            {
                if (campaign.GetCampaignId() == order.CampaignID) { 
                    this._CampaignRate = campaign.SetCampaignRate();
                    this._CampaignID = order.CampaignID;
                    this._CampaignName = campaign.GetCampaignName();
                


                double rate = _CampaignRate;
            double operation = order.Price - (order.Price * rate);
            Console.WriteLine( "\n##### Discount Amount Calculator #####" +
                               "\nCampaign Name: " + _CampaignName +
                               "\nPrice: " + order.Price +
                               "\nNew Price: " + operation +
                               "\nDiscount Rate: %" + rate +
                               "\nDiscount Amount: " +  (order.Price - operation) +
                               "\n  [Calculated]");
                }
                else if (order.CampaignID <= 0){ Console.WriteLine("\nNo Campaign Defined To This Game."); break ; }

            } 
            return order.Price - (order.Price * _CampaignRate);
        }

        public double SetCampaignRate()
        {
            return this._CampaignRate;
        }

        public int GetCampaignId()
        {
            return this._CampaignID;
        }

        public string GetCampaignName()
        {
            return this._CampaignName;
        }
    }
}
