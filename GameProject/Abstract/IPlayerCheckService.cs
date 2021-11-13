using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
