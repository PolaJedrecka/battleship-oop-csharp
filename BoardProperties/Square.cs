using System;

namespace battleship.BoardProperties
{
    public class Square
    {
        
        private (int y, int x) _position;
        private SquareStatus _status;
        private bool _isPlacementOk; 

        public Square(int y, int x)
        {
            _position = (y, x);
            _status = SquareStatus.Empty;
            _isPlacementOk = true;
        }

        public void SetPlacementNotOk()
        {
            _isPlacementOk = false;
        }
        
        public bool GetPlacementOk()
        {
            return _isPlacementOk;
        }
        public void SetMissedStatus()
        {
            _status = SquareStatus.Missed;
        }

        public void SetHitStatus()
        {
            _status = SquareStatus.Hit;
        }
        
        public void SetShipStatus()
        {
            _status = SquareStatus.Ship;
            SetPlacementNotOk();
        }

        public SquareStatus GetStatus()
        {
            return _status;
        }
        
        public string GetCharacter()
        { 
            if (_status == SquareStatus.Empty)
            {
                return "   ";
            }
            else if (_status == SquareStatus.Hit)
            {
                return " ⓧ ";
            }
            else if (_status == SquareStatus.Missed)
            {
                return " ✘ ";
            }
            else
            {
                return " Ο ";
            }
        }
    }
}