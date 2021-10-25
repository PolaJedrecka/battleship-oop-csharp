using System;

namespace battleship.Board
{
    public class Square
    {
        private (int x, int y) Position { get; set; }

        private SquareStatus Status { get; set; }

        public Square()
        {
            Status = SquareStatus.Empty;
        }

        public void DisplaySquareStatus()
        {
        }

        public string GetCharacter()
        {
            if (Status == SquareStatus.Empty)
            {
                return " ";
            } else if (Status == SquareStatus.Hit)
            {
                return "X";
            } else if (Status == SquareStatus.Missed)
            {
                return "#";
            }
            else
            {
                return "$";
            }
        }
    }
}