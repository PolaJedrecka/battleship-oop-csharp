﻿using System;
using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.ShipProperties;
using battleship.Users;
using battleship.Users.ComputerPlayer;

namespace battleship.GameProperties
{
    

    public class Game
    {
        private Input _input = new Input();
        private Display _display = new Display();
        private List<Ship> _listOfAvailableShips;
        private string Winner { get; set; }

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

        public void Run(int gameMode, string opponentMode)
        {
            if (opponentMode == "Player vs. Player")
            {
                Player player1 = new HumanPlayer();
                Player player2 = new HumanPlayer();
                Round(player1, player2);
            } else if (opponentMode == "Player vs. Computer")
            {
                Player player1 = new HumanPlayer();
                Player player2;
                switch (gameMode)
                {
                    case 0:
                        player2 = new EasyComputerPlayer();
                        break;
                    case 1:
                        player2 = new NormalComputerPlayer();
                        break;
                    case 2:
                        player2 = new HardComputerPlayer();
                        break;
                    default:
                        player2 = new NormalComputerPlayer();
                        break;
                }
                Round(player1, player2);
            }
            else
            {
                Player player1;
                Player player2;
                switch (gameMode)
                {
                    case 0:
                        player1 = new EasyComputerPlayer();
                        player2 = new EasyComputerPlayer();
                        break;
                    case 1:
                        player1 = new NormalComputerPlayer();
                        player2 = new NormalComputerPlayer();
                        break;
                    case 2:
                        player1 = new HardComputerPlayer();
                        player2 = new HardComputerPlayer();
                        break;
                    default:
                        player1 = new NormalComputerPlayer();
                        player2 = new NormalComputerPlayer();
                        break;
                }
                Round(player1, player2);
            }
        }
        
        // TODO: hasWon method
        // TODO: game over condition
        
        private void Round(Player player1, Player player2)
        {
            player1.DeployShips(_listOfAvailableShips);
            player2.DeployShips(_listOfAvailableShips);
            Player shooter = player1;
            Player receiver = player2;
            while (!HasWon(player1,player2))
            {
                shoot(shooter,receiver);
                (shooter, receiver) = (receiver, shooter);
            }

            Winner = null; // TODO: przypisanie winnera
            // _display.DisplayThePlayerWhichWonTheGame(Winner);
        }

        public void shoot(Player shooter, Player receiver)
        {
            (int x, int y) shootCoords = shooter.GiveAShootCoords(receiver.getOwnBoard().GetSize());
            Square shootSquare = receiver.getOwnBoard().GetSquare(shootCoords.y, shootCoords.x);
            if (shootSquare.GetStatus() == SquareStatus.Ship)
            {
                shootSquare.SetHitStatus();
            }else if (shootSquare.GetStatus() == SquareStatus.Empty)
            {
                shootSquare.SetMissedStatus();
            }
            else
            {
                shoot(shooter,receiver);
            }
        }
        private bool HasWon(Player player1, Player player2)
        {
            //TODO: logika wygrywania)
            return true;
        }
    }
}