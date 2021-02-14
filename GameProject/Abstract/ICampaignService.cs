using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void UpDate(Campaign campaign);
        public void Delete(Campaign campaign);
    }
}