using System.Collections.Generic;
using battleship.ShipProperties;

namespace battleship.Users.ComputerPlayer
{
    using BoardProperties;

    public class NormalComputerPlayer : Player
    {
        public override (int y, int x) GiveAShootCoords(int size, Board enemyBoard)
        {
            throw new System.NotImplementedException();
        }

        public override void DeployShips(List<Ship> listOfships)
        {
            throw new System.NotImplementedException();
        }

        public NormalComputerPlayer(string name) : base(name)
        {
        }
    }
}