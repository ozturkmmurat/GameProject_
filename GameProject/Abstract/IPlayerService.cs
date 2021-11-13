using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPlayerService
    {
        void Create(Player player);
        void Update(Player player);
        void Delete(Player player);  
    } 
}
