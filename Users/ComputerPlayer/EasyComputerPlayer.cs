using System;
using System.Collections.Generic;
using battleship.ShipProperties;

namespace battleship.Users.ComputerPlayer
{
    using BoardProperties;

    public class EasyComputerPlayer : Player
    {
        public override (int y, int x) GiveAShootCoords(int size, Board enemyBoard)
        {
            Random random = new Random();
            int x = random.Next(0, size);
            int y = random.Next(0, size);
            return (y, x);
        }

        public override void DeployShips(List<Ship> listOfships)
        {
            throw new NotImplementedException();
        }
    }
}