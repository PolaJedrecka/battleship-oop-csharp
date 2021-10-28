using System.Collections.Generic;
using battleship.BoardProperties;

namespace battleship.ShipProperties
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