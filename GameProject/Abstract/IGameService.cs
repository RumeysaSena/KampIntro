using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        public void Add( Game game);
        public void UpDate(Game game);
        public void Delete(Game game);

    }
}