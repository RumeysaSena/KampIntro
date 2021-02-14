using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void UpDate(Campaign campaign);
        void Delete(Campaign campaign);
    }
}