using System;

namespace battleship.BoardProperties
{
    public class Square
    {
        private (int y, int x) Position { get; set; }

        private SquareStatus Status { get; set; }

        public Square(int y, int x)
        {
            Position = (y, x);
            Status = SquareStatus.Empty;
        }

        public void SetMissedStatus()
        {
            Status = SquareStatus.Missed;
        }

        public void SetHitStatus()
        {
            Status = SquareStatus.Hit;
        }
        
        public void SetShipStatus()
        {
            Status = SquareStatus.Ship;
            // setPlacementNotOK();
        }

        public string GetCharacter()
        {
            if (Status == SquareStatus.Empty)
            {
                return "   ";
            }
            else if (Status == SquareStatus.Hit)
            {
                return " X ";
            }
            else if (Status == SquareStatus.Missed)
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