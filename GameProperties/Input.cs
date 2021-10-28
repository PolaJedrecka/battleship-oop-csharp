using System;
using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;

namespace battleship.GameProperties
{
    public class Input
    {
        private Display _display = new Display();
        public (int,int) CursorMovement(Cursor cursor)
        {   
            ConsoleKey _key = ConsoleKey.NoName;

            while (_key != ConsoleKey.Enter)
            {
                _display.DisplayBoardShipPlacement(cursor,4);
                _key = Console.ReadKey().Key;
                switch (_key)
                {
                    case ConsoleKey.A:
                        cursor.MoveLeft();
                        break;
                    case ConsoleKey.D:
                        cursor.MoveRight();
                        break;
                    case ConsoleKey.W:
                        cursor.MoveUp();
                        break;
                    case ConsoleKey.S:
                        cursor.MoveDown();
                        break;
                    case ConsoleKey.Q:
                        if (cursor.GetIsVertical())
                        {
                            cursor.ChangeCursorHorizontal();
                        }
                        else
                        {
                            cursor.ChangeCursorVertical();
                        }
                        break;
                }
            }

            return (cursor.GetY(), cursor.GetX());
        }
        
        public List<Square> ShipPlacement(Cursor cursor, Ship ship)
        {
            CursorMovement(cursor);
            ship.GetLength();
            _display.DisplayBoardShipPlacement(cursor,ship.GetLength());
            return new List<Square>();
        }

        public ConsoleKey GetKey()
        {
            return Console.ReadKey().Key;
        }
    }
}