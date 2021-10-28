using System;
using System.Collections.Generic;
using battleship.GameProperties;
using battleship.ShipProperties;

namespace battleship.Users.ComputerPlayer
{
    using BoardProperties;

    public class EasyComputerPlayer : Player
    {
        Random random = new Random();
        private Display display = new Display();
        
        public override (int y, int x) GiveAShootCoords(int size, Board enemyBoard)
        {
            
            int x = random.Next(0, size);
            int y = random.Next(0, size);
            display.DisplayGameplay(new Cursor(y,x,true), enemyBoard, Name);
            return (y, x);
        }

        public override void DeployShips(List<Ship> listOfships)
        {
            setLives(listOfships);
            _boardFactory.RandomPlacement(listOfships, OwnBoard);
        }

        public EasyComputerPlayer(string name) : base(name)
        {
        }
    }
}