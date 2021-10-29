using System.Collections.Generic;
using battleship.ShipProperties;
using battleship.BoardProperties;

namespace battleship.Users.ComputerPlayer
{
    public class HardComputerPlayer : Player
    {
        public override (int y, int x) GiveAShootCoords(int size, Board enemyBoard)
        {
            throw new System.NotImplementedException();
        }

        public override void DeployShips(List<Ship> listOfships)
        {
            throw new System.NotImplementedException();
        }

        public HardComputerPlayer(string name) : base(name)
        {
        }
    }
}