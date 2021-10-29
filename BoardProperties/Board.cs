namespace battleship.BoardProperties
{
    public class Board
    {
        private readonly Square[,] _ocean;
        private int _size;

        public Board(int size)
        {
            _size = size;
            _ocean = new Square[size, size];

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    _ocean[y, x] = new Square(y, x);
                }
            }
        }

        public Square GetSquare(int y, int x)
        {
            return _ocean[y, x];
        }

        public int GetSize()
        {
            return _size;
        }
    }
}