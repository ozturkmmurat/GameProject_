using GameProject.Abstract;
using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Create(Game game)
        {
            Console.WriteLine(game.GameName_OyunAdi + " Adında ve ücreti " + game.GamePrice_OyunUcreti + " oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName_OyunAdi + " Adında ve ücreti " + game.GamePrice_OyunUcreti + " oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName_OyunAdi + " Adında ve ücreti " + game.GamePrice_OyunUcreti + " oyun güncellendi");
        }
    }
}
