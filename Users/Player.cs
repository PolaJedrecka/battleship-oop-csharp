using battleship.BoardProperties;

namespace battleship.Users
{
    public abstract class Player
    {
        protected Board ownBoard = new Board(10);
        
            public abstract (int y, int x) GiveAShootCoords(int size);
            public abstract void DeployShips();

    }
}