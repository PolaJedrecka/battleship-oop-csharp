using System;
using System.Collections.Generic;
using battleship.Board;
using battleship.Game;
using battleship.Ship;

namespace battleship
{
    public class Battleship
    {
        private static Display _display = new Display();
        //private static Cursor _cursor = new Cursor();
        private static Input _input = new Input();
        public static void Main(string[] args)
        {
            // Ship.Ship ship = new Ship.Ship(ShipType.Battleship);
            //while (true)
            
            _display.DisplayMainMenu(_input);
            //_display.DisplayBoardShipPlacment(_cursor,ship.GetLength());
            //_input.ShipPlacment(_cursor, ship);
            //Console.ReadKey();
            
            
        }
    }
}