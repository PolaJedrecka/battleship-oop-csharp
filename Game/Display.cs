using System;
using battleship.Board;

namespace battleship.Game
{
    public class Display
    {
        public void DisplayBoard(Cursor cursor, Board.Board board, bool isOk = true, int shipLength = 1)
        {
            Console.Clear();
            ConsoleColor foregroundColor = Console.ForegroundColor;
            ConsoleColor backgroundColor = Console.BackgroundColor;

            for (int y = 0; y < board.GetSize(); y++)
            {
                for (int x = 0; x < board.GetSize(); x++)
                {
                    if (cursor.GetX() <= x && cursor.GetX() + shipLength > x && cursor.GetY() == y &&
                        cursor.GetIsVertical() || cursor.GetX() == x && cursor.GetY() + shipLength > y &&
                        cursor.GetY() <= y &&
                        !cursor.GetIsVertical())
                    {
                        if (isOk)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                    }
                   
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }

                    Console.Write(board.GetSquare(y, x).GetCharacter());
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }
    }
}