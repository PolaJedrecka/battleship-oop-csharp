using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;

namespace battleship.Users
{
    public abstract class Player
    {
        protected Board ownBoard = new Board(10);
        protected bool isAlive = true;
        protected int lives;
        
        public abstract (int y, int x) GiveAShootCoords(int size);
        public abstract void DeployShips(List<Ship> listOfships);

        public Board GetOwnBoard()
        {
            return ownBoard;
        }
        
        public bool GetIsAlive()
        {
            return isAlive;
        }

        public void setLives(List<Ship> listOfShips)
        {
            foreach (Ship ship in listOfShips)
            {
                lives += ship.GetHashCode();
            }
        }

        public void updateLives()
        {
            lives--;
            if (lives == 0)
            {
                SetIsDead();
            }
        }
        
        public bool SetIsDead()
        {
            return isAlive = false;
        }

    }
}