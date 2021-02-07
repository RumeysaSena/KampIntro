using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
