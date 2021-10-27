namespace battleship.Board
{
    public class Board
    {
        private readonly Square[,] _ocean;
        private int size;

        public Board(int size)
        {
            this.size = size;
            _ocean = new Square[size, size];
            
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    _ocean[y, x] = new Square(y, x);
                }
            }
        }
    }
}