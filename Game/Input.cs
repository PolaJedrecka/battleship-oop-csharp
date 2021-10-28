using System;
using System.Collections.Generic;
using battleship.Board;

namespace battleship.Game
{
    public class Input
    {
        private Display _display = new Display();

        public (int, int) CursorMovement(Cursor cursor, Board.Board board, Ship.Ship ship = null)
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

        public void SetPlacementNotOkAroundSquare(int y, int x, Board.Board board, bool isVertical)
        {
            if (y - 1 > 0 && x - 1 > 0)
            {
                board.GetSquare(y - 1, x - 1).SetPlacementNotOk();
            }

            if (y + 1 < board.GetSize() && x - 1 > 0)
            {
                board.GetSquare(y + 1, x - 1).SetPlacementNotOk();
            }

            if (y - 1 > 0 && x + 1 < board.GetSize())
            {
                board.GetSquare(y - 1, x + 1).SetPlacementNotOk();
            }

            if (y + 1 < board.GetSize() && x + 1 < board.GetSize())
            {
                board.GetSquare(y + 1, x + 1).SetPlacementNotOk();
            }

            if (isVertical)
            {
                if (x - 1 > 0)
                {
                    board.GetSquare(y, x - 1).SetPlacementNotOk();
                }

                if (x + 1 < board.GetSize())
                {
                    board.GetSquare(y, x + 1).SetPlacementNotOk();
                }
            }
            else
            {
                if (y - 1 > 0)
                {
                    board.GetSquare(y - 1, x).SetPlacementNotOk();
                }

                if (y + 1 < board.GetSize())
                {
                    board.GetSquare(y + 1, x).SetPlacementNotOk();
                }
            }
        }

        public void ShipPlacement(Cursor cursor, Ship.Ship ship, Board.Board board)
        {
            (int y, int x) firstBlockOfShip = CursorMovement(cursor, board, ship);

            for (int i = 0; i < ship.GetLength(); i++)
            {
                if (cursor.GetIsVertical())
                {
                    SetPlacementNotOkAroundSquare(firstBlockOfShip.y, firstBlockOfShip.x + i, board,
                        cursor.GetIsVertical());
                    board.GetSquare(firstBlockOfShip.y, firstBlockOfShip.x + i).SetShipStatus();
                }
                else
                {
                    SetPlacementNotOkAroundSquare(firstBlockOfShip.y + i, firstBlockOfShip.x, board,
                        cursor.GetIsVertical());
                    board.GetSquare(firstBlockOfShip.y + i, firstBlockOfShip.x).SetShipStatus();
                }
            }
        }

        public bool checkPositionIsOk(Cursor cursor, Board.Board board, int length)
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
    }
}