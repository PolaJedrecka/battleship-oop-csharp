using System;
using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;

namespace battleship.GameProperties
{
    public class Input
    {
        private Display _display = new Display();

        public (int, int) CursorMovement(Cursor cursor, Board board, Ship ship = null)
        {
            ConsoleKey _key;
            int length;
            bool isSuccess = false;
            
            while (!isSuccess)
            {
                if (ship is null)
                {
                    _display.DisplayBoard(cursor, board);
                    length = 1;
                }
                else
                {
                    bool isOk = checkPositionIsOk(cursor, board, ship.GetLength());
                    _display.DisplayBoard(cursor, board, isOk, ship.GetLength());
                    length = ship.GetLength();
                    
                }

                _key = Console.ReadKey().Key;
                switch (_key)
                {
                    case ConsoleKey.A:
                        if (cursor.GetX() > 0)
                        {
                            cursor.MoveLeft();
                        }
                        break;
                    
                    case ConsoleKey.D:
                        if (!cursor.GetIsVertical())
                        {
                            length = 1;
                        }

                        if (cursor.GetX() + length < board.GetSize())
                        {
                            cursor.MoveRight();
                        }

                        break;
                    
                    case ConsoleKey.W:
                        if (cursor.GetY() > 0)
                        {
                            cursor.MoveUp();
                        }

                        break;
                    
                    case ConsoleKey.S:
                        if (cursor.GetIsVertical())
                        {
                            length = 1;
                        }

                        if (cursor.GetY() + length < board.GetSize())
                        {
                            cursor.MoveDown();
                        }

                        break;
                    
                    case ConsoleKey.Q:
                        if (cursor.GetIsVertical() && cursor.GetY() + length <= board.GetSize())
                        {
                            cursor.ChangeCursorHorizontal();
                        }
                        else if (!cursor.GetIsVertical() && cursor.GetX() + length <= board.GetSize())
                        {
                            cursor.ChangeCursorVertical();
                        }

                        break;
                    
                    case ConsoleKey.Enter:
                        if (!(ship is null) && checkPositionIsOk(cursor, board, ship.GetLength()))
                        {
                            isSuccess = true;
                        }

                        break;
                }
            }

            return (cursor.GetY(), cursor.GetX());
        }
        
        public bool checkPositionIsOk(Cursor cursor, Board board, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (cursor.GetIsVertical())
                {
                    if (!board.GetSquare(cursor.GetY(), cursor.GetX() + i).GetPlacementOk())
                    {
                        return false;
                    }
                }
                else
                {
                    if (!board.GetSquare(cursor.GetY()+i, cursor.GetX()).GetPlacementOk())
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public ConsoleKey GetKey()
        {
            return Console.ReadKey().Key;
        }
    }
}