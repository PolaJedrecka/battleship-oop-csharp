using System;
using System.Collections.Generic;
using battleship.BoardProperties;
using battleship.GameProperties;
using battleship.ShipProperties;

namespace battleship
{
    public class Battleship
    {
        private static Input _input = new Input();
        private static Display _display = new Display();
        public static void Main(string[] args)
        {
            bool gameIsRunning = false;
            while (!gameIsRunning)
            {
                _display.DisplayMainMenu(_input);
                int gameMode = _display.GameMode;
                if (gameMode == 0 || gameMode == 1 || gameMode == 2)
                {
                    _display.DisplayOpponentMode(_input);
                    string opponentMode = _display.OpponentMode;
                    Game game = new Game(gameMode);
                    game.Run(gameMode, opponentMode);
                } else if (gameMode == 3)
                {
                    List<string> test = new List<string>() {"Not implemented yet"};
                    _display.DisplayHighScores(test);
                    _input.GetKey();
                }
                else
                {
                    gameIsRunning = true;
                }
            }
            
        }
    }
}