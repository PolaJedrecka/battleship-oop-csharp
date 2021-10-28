using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;

namespace battleship.Users
{
    public abstract class Player
    {
        protected Board ownBoard = new Board(10);
        
        
        public abstract (int y, int x) GiveAShootCoords(int size, Board enemyBoard);
        public abstract void DeployShips(List<Ship> listOfships);

        public Board getOwnBoard()
        {
            return ownBoard;
        }

    }
}