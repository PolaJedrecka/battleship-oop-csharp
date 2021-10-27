using System;
using System.Collections.Generic;
using battleship.Board;
using battleship.Ship;

namespace battleship.Game
{
    public class Game
    {
        private Cursor _cursor = new Cursor();
        private Input _input = new Input();
        private Display _display = new Display();

        public void Run()
        {
            _display.DisplayMainMenu(_input);
        }
        
        //_display.DisplayBoardShipPlacment(_cursor,ship.GetLength());
        //_input.ShipPlacment(_cursor, ship);
        //Console.ReadKey();
        // TODO: choosing game mode
        // TODO: hasWon method
        // TODO: game over condition
        // TODO: Round flow
        // TODO: game loop
    }
}