using System;
using battleship.Board;

namespace battleship.Game
{
    using System.Collections.Generic;

    public class Display
    {
        public void DisplayBoard(Cursor cursor)
        {
            Console.Clear();
            ConsoleColor foregroundColor = Console.ForegroundColor;
            ConsoleColor backgroundColor = Console.BackgroundColor;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (cursor.GetX() == x && cursor.GetY() == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }

                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }

        public void DisplayBoardShipPlacment(Cursor cursor, int shipLength)
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

        public void DisplayMainMenu(Input input)
        {
            List<string> listOfOptions = new List<string>() {"Start", "High scores", "Exit"};
            bool success = false;
            int pointer = 0;
            while (!success)
            {
                Console.Clear();
                Console.WriteLine("     Hi! Welcome to Battleship Game!");
                for (int i = 0; i < listOfOptions.Count; i++)
                {
                    if (pointer == i)
                    {
                        Console.WriteLine("     "+">>"+ listOfOptions[i] +"<<");
                    }
                    else
                    {
                        Console.WriteLine("     "+listOfOptions[i]);
                    }
                }
                ConsoleKey key = input.GetKey();
                pointer = Pointer(key, pointer);
                if (key == ConsoleKey.Enter)
                {
                    success = true;
                }
                
            }
            
            switch(pointer)
            {
                case 0:
                    Console.WriteLine("dupa start");
                    //Game.StartGame();
                    break;
                case 1:
                    Console.WriteLine("dupa najwyższe wyniki");
                    //DisplayHighScores;
                    break;
                case 2:
                    break;
            }
        }

        public int Pointer(ConsoleKey key, int pointer)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (pointer != 0)
                    {
                        pointer--;
                    }
                    else
                    {
                        pointer = 2;
                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (pointer != 2)
                    {
                        pointer++;
                    }
                    else
                    {
                        pointer = 0;
                    }

                    break;
            }

            return pointer;
        }
    }
}