using System.Collections.Generic;
using battleship.Board;

namespace battleship.Ship
{
    public class Ship
    {
        private ShipType type;

        public Ship(ShipType type)
        {
            this.type = type;
        }

        public int GetLength()
        {
            return type.GetHashCode();
        }
    }
}