using GameProject.Abstract;
using GameProject.Entitys;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        Convert.ToInt64(player.IdentityNumber_TcNo),
                        player.Name_Ad.ToUpper(),
                        player.SurName_Soyad.ToUpper(),
                        player.DateOfBirth_DogumTarihi.Year)))
                    .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
