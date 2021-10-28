using System.Collections.Generic;
using battleship.BoardProperties;

namespace battleship.ShipProperties
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