using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi! : " + campaign.CampaignName + " İndirim Oranı: " + campaign.DiscountRate + '\n');
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "'nın süresi dolduğundan kampanya silindi." + '\n');
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi! : " + campaign.CampaignName + " İndirim Oranı : " + campaign.DiscountRate + '\n');
        }
    }
}