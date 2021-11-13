using GameProject.Abstract;
using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(game.GameName_OyunAdi + " adlı oyun bu fiyattan " + (game.GamePrice_OyunUcreti - campaign.CampaignDiscount_KampanyaIndirimi) + " şu oyuncuya satılmıştır " + player.Name_Ad);
        }
    }
}
