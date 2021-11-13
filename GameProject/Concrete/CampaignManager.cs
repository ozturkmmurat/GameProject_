using GameProject.Abstract;
using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Create(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName_KampanyaAdi + " kampanya oluşturuldu");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName_KampanyaAdi + " kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName_KampanyaAdi + " kampanya güncellendi");
        }
    }
}
