using System;
using System.Collections.Generic;
using System.Text;

namespace Play2048
{
    class Game
    {
        public Board GameBoard { get; set; }
        public GameStatus CorrentStatus { get; set; }
        public int ScoreCount { get; protected set; }

        public Game()
        {
            GameBoard = new Board();
            CorrentStatus = GameStatus.Idle;
            ScoreCount = 0;
            GameBoard.RandomFirstPlaces();
        }


        public void Move(Direction direction)
        {
            if (direction != Direction.End)
            {
                if(CorrentStatus== GameStatus.Idle)
                {
                    ScoreCount += GameBoard.Move(direction);
                    if (GameBoard.HelpFunctions.WinAlready(GameBoard.Data))
                    {
                        CorrentStatus = GameStatus.Win;
                    }
                    else if (GameBoard.HelpFunctions.IsFull(GameBoard.Data))
                    {
                        CorrentStatus = GameStatus.Lose;
                    }
                }            
            }
            else
            {
                CorrentStatus = GameStatus.Quit;
            }
        }
        public void PrintBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameBoard.Data[i, j] < 10)
                    {
                        if (GameBoard.Data[i, j] != 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write(GameBoard.Data[i, j]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("    ");
                        }
                    }
                    else if (GameBoard.Data[i, j] < 100)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(GameBoard.Data[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("   ");
                    }
                    else if (GameBoard.Data[i, j] < 1000)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(GameBoard.Data[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                    }
                    else if (GameBoard.Data[i, j] < 2049)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(GameBoard.Data[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }           
                Console.Write("\n \n");
            }
            Console.Write("\n");
        }
    }
}
