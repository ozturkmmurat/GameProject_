using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entitys;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player
            {
                PlayerId = 1,
                Name_Ad = "Murat",
                SurName_Soyad = "Öztürk",
                DateOfBirth_DogumTarihi = new DateTime(1999, 8, 11),
                IdentityNumber_TcNo = "30500502780"

            };
            PlayerManager playerManager = new PlayerManager(new MernisAdapter());
            playerManager.Create(player);



            Game game = new Game
            {
                GameId = 1,
                GameName_OyunAdi = "Mario",
                GamePrice_OyunUcreti = 100,
                GameAmount_OyunAdeti = 25
            };
            GameManager gameManager = new GameManager();
            gameManager.Create(game);



            Campaign campaign = new Campaign
            {
                CampaignName_KampanyaAdi = "Yaz İndirimi",
                CampaignDiscount_KampanyaIndirimi = 10
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Create(campaign);


            SaleManager saleManager = new SaleManager();
            saleManager.Sell(game, player, campaign);

            playerManager.Delete(player);
        }
    }
}
