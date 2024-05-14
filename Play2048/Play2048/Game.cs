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
            switch (CorrentStatus)
            {
                case GameStatus.Lose:
                    break;

                case GameStatus.Idle:
                    ScoreCount+= GameBoard.Move(direction);
                    if(GameBoard.WinAlready())
                    {
                        CorrentStatus = GameStatus.Win;
                    }
                    else if(GameBoard.IsFull())
                    {
                        CorrentStatus = GameStatus.Lose;
                    }
                    break;

                case GameStatus.Win:
                    break;

            }
        }
        public void PrintBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(GameBoard.Data[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
