using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.GameProperties;
using battleship.ShipProperties;

namespace battleship.Users
{
    public class HumanPlayer : Player
    {
        private Input _input = new Input();
        private Cursor _cursor = new Cursor();
        
        
        public override (int y, int x) GiveAShootCoords(int size, Board enemyBoard)
        {
            return _input.CursorMovement(_cursor, enemyBoard);
        }

        public override void DeployShips(List<Ship> listOfShips)
        {
            setLives(listOfShips);
            _boardFactory.ManualPlacement(listOfShips,ownBoard);
        }
    }
}