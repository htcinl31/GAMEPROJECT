using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEPROJECT
{
    class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine(game.GameName + " " + "oyunu eklendi");
        }

        public void Delete(Games game)
        {
            Console.WriteLine(game.GameName +" "+ " oyunu silindi");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GameName +" " +"oyunu güncellendi");
        }
    }
}
