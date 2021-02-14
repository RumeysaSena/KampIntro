using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Eklendi." + '\n');
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Silindi." + '\n');
        }

        public void UpDate(Game game)
        {
            Console.WriteLine(game.GameName + "Güncellendi." + '\n');
        }
    }
}
