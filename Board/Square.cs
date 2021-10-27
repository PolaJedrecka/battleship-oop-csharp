using System;

namespace battleship.Board
{
    public class Square
    {
        private (int y, int x) Position { get; set; }

        private SquareStatus Status { get; set; }

        public Square(int y, int x)
        {
            Status = SquareStatus.Empty;
            Position = (y, x);
        }

        public void DisplaySquareStatus()
        {
        }

        public string GetCharacter()
        { 
            if (Status == SquareStatus.Empty)
            {
                return "   ";
            } else if (Status == SquareStatus.Hit)
            {
                return " X ";
            } else if (Status == SquareStatus.Missed)
            {
                return " # ";
            }
            else
            {
                return " $ ";
            }
        }
    }
}