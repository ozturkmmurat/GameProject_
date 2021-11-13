using GameProject.Abstract;
using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Create(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.Name_Ad + " adında oyuncu oluşturuldu");
            }
            else
            {
                Console.WriteLine("Bu kimlik bilgisinde biri bulunmuyor kontrol ediniz");
            }
          
        }

        public void Delete(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.Name_Ad + " adında oyuncu silindi");
            }
            else
            {
                Console.WriteLine("Bu kimlik bilgisinde biri bulunmuyor kontrol ediniz");
            }
        }

        public void Update(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.Name_Ad + " adında oyuncu silindi");
            }
            else
            {
                Console.WriteLine("Bu kimlik bilgisinde biri bulunmuyor kontrol ediniz");
            }
        }
    }
}
