using System.Collections.Generic;
using battleship.GameProperties;
using battleship.ShipProperties;

namespace battleship.BoardProperties
{
    using System;

    public class BoardFactory
    {
        private Cursor _cursor = new Cursor();
        private Input _input = new Input();
        private Random _random = new Random();
        
        public void RandomPlacement(List<Ship> listOfAvailableShips, Board board)
        {
            foreach (Ship ship in listOfAvailableShips)
            {
                bool isVertical;
                bool isSuccessed = false;
                int x = 0;
                int y = 0;
                while (!isSuccessed)
                {
                    x = _random.Next(0, board.GetSize());
                    y = _random.Next(0, board.GetSize());
                    if (board.GetSquare(y, x).GetPlacementOk())
                    {
                        isSuccessed = true;
                    }
                }

                int randomIsVertical = _random.Next(0, 1);
                if (randomIsVertical == 0)
                {
                    isVertical = true;
                }
                else
                {
                    isVertical = false;
                }

                Cursor cursor = new Cursor(y, x, isVertical);
                ShipPlacement(ship, board, cursor, true);
            }
        }

        public void ManualPlacement(List<Ship> listOfAvailableShips, Board board)
        {
            foreach (Ship ship in listOfAvailableShips)
            {
                ShipPlacement(ship, board, _cursor);
            }
        }
        
        public void SetPlacementNotOkAroundSquare(int y, int x, Board board, bool isVertical)
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

        public void ShipPlacement(Ship ship, Board board, Cursor cursor, bool IsComputerPlayer = false)
        {
            (int y, int x) firstBlockOfShip;
            
            if (IsComputerPlayer)
            {
                firstBlockOfShip = (cursor.GetY(), cursor.GetX());
            }
            else
            {
                firstBlockOfShip = _input.CursorMovement(cursor, board, "Player 1", ship);
            }
            
            for (int i = 0; i < ship.GetLength(); i++)
            {
                if (_cursor.GetIsVertical())
                {
                    SetPlacementNotOkAroundSquare(firstBlockOfShip.y, firstBlockOfShip.x + i, board,
                        _cursor.GetIsVertical());
                    board.GetSquare(firstBlockOfShip.y, firstBlockOfShip.x + i).SetShipStatus();
                }
                else
                {
                    SetPlacementNotOkAroundSquare(firstBlockOfShip.y + i, firstBlockOfShip.x, board,
                        _cursor.GetIsVertical());
                    board.GetSquare(firstBlockOfShip.y + i, firstBlockOfShip.x).SetShipStatus();
                }
            }
        }
        
    }
}