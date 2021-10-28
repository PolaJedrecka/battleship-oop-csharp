using System;
using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;
using battleship.Users;

namespace battleship.GameProperties
{
    public class Game
    {
        private Cursor _cursor = new Cursor();
        private Input _input = new Input();
        private List<Ship> _listOfAvailableShips;

        public Game(int gameMode)
        {
            switch (gameMode)
            {
                case 0:
                    _listOfAvailableShips = new List<Ship>() {new Ship(ShipType.Submarine)};
                    break;
                case 1:
                    _listOfAvailableShips = new List<Ship>() {new Ship(ShipType.Cruiser)};
                    break;
                case 2:
                    _listOfAvailableShips = new List<Ship>() {new Ship(ShipType.Destroyer)};
                    break;
            }
        }

        public void Run(string OpponentMode)
        {
            if (OpponentMode == "Player vs. Player")
            {
                Player player1 = new Player();
                Player player2 = new Player();
                Round(player1, player2);
            } else if (OpponentMode == "Player vs. Computer")
            {
                Player player1 = new Player();
                Player player2 = new ComputerPlayer();
                Round(player1, player2);
            }
            else
            {
                Player player1 = new ComputerPlayer();
                Player player2 = new ComputerPlayer();
                Round(player1, player2);
            }
        }
        
        // TODO: hasWon method
        // TODO: game over condition
        
        private void Round(Player player1, Player player2)
        {
            //Player1.DeployShips
            //Player2.DeployShips
            //while (!HasWon())
            //Player1.Shoot
            //Player2.Shoot
        }
        
        private bool HasWon()
        {
            //TODO: logika wygrywania
            return true;
        }
    }
}