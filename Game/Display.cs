using System;
using battleship.Board;

namespace battleship.Game
{
    public class Display
    {
        public void DisplayBoard(Cursor cursor, int shipLength = 1)
        {
            
            Console.Clear();
            ConsoleColor foregroundColor = Console.ForegroundColor;
            ConsoleColor backgroundColor = Console.BackgroundColor;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (cursor.GetX() <= x && cursor.GetX() + shipLength > x && cursor.GetY() == y &&
                        cursor.GetIsVertical())
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (cursor.GetX() == x && cursor.GetY() + shipLength > y && cursor.GetY() <= y &&
                             !cursor.GetIsVertical())
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write("   ");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }
    }
}