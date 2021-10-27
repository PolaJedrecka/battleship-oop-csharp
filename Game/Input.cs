using System;
using System.Collections.Generic;
using battleship.Board;

namespace battleship.Game
{
    public class Input
    {
        private Display _display = new Display();
        public (int,int) CursorMovement(Cursor cursor)
        {   
            ConsoleKey _key = ConsoleKey.NoName;

            while (_key != ConsoleKey.Enter)
            {
                _display.DisplayBoard(cursor);
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
        
        public List<Square> ShipPlacment(Cursor cursor, Ship.Ship ship)
        {
            CursorMovement(cursor);
            ship.GetLength();
            _display.DisplayBoard(cursor,ship.GetLength());
            return new List<Square>();
        }
    }
}