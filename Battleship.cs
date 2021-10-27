using System;
using System.Collections.Generic;
using battleship.Board;
using battleship.Game;
using battleship.Ship;

namespace battleship
{
    public class Battleship
    {
        public static void Main(string[] args)
        {
            Game.Game game = new Game.Game();
            game.Run();
        }
    }
}