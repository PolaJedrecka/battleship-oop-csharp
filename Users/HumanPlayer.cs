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
        private BoardFactory _boardFactory= new BoardFactory();
        
        public override (int y, int x) GiveAShootCoords(int size)
        {
            return _input.CursorMovement(_cursor, ownBoard);
        }

        public override void DeployShips(List<Ship> listOfShips)
        {
            _boardFactory.ManualPlacement(listOfShips,ownBoard);
        }
    }
}