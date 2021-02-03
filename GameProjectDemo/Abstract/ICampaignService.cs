using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
   public interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void UpgradeCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);


    }
}
