using battleship.BoardProperties;
using battleship.GameProperties;

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

        public override void DeployShips()
        {
            _boardFactory.
        }
    }
}