using System.Collections.Generic;
using battleship.Board;

namespace battleship.Ship
{
    public class Ship
    {
        private ShipType type;
        private List<Square> position;

        public Ship(ShipType type)
        {
            this.type = type;
            // this.position = position;
        }

        public int GetLength()
        {
            return type.GetHashCode();
        }
    }
}