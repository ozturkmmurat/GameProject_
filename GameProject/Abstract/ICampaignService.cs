using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Create(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
