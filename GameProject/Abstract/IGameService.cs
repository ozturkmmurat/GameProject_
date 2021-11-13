using GameProject.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Create(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
