using System;

namespace battleship.BoardProperties
{
    public class Cursor
    {
        private (int x, int y) Position { get; set; }
        private bool isVertical;

        public Cursor()
        {
            Position = (0, 0);
            isVertical = true;
        }

        public Cursor(int x, int y, bool isVertical)
        {
            this.isVertical = isVertical;
            Position = (x, y);
        }

        public void MoveLeft()
        {
            var valueTuple = this.Position;
            valueTuple.x--;
            Position = valueTuple;
        }
        
        public void MoveRight()
        {
            var valueTuple = this.Position;
            valueTuple.x++;
            Position = valueTuple;
        }
        
        public void MoveUp()
        {
            var valueTuple = this.Position;
            valueTuple.y--;
            Position = valueTuple;
        }
        
        public void MoveDown()
        {
            var valueTuple = this.Position;
            valueTuple.y++;
            Position = valueTuple;
        }

        public int GetX()
        {
            return Position.x;
        }

        public int GetY()
        {
            return Position.y;
        }

        public void ChangeCursorHorizontal()
        {
            isVertical = false;
        }
        
        public void ChangeCursorVertical()
        {
            isVertical = true;
        }

        public bool GetIsVertical()
        {
            return isVertical;
        }
    }
}