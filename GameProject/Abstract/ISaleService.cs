using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sell(Game game, Player player, Campaign campaign);
    }
}
