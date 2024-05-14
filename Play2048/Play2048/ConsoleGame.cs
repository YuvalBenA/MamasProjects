using System;
using System.Collections.Generic;
using System.Text;

namespace Play2048
{
    class ConsoleGame
    {

        public Direction TurnsDirection()
        {
            ConsoleKeyInfo moveDirection = Console.ReadKey();
            switch ((int)moveDirection.Key)
            {
                case 37:
                    return Direction.Left;
                case 38:
                    return Direction.Up;
                case 39:
                    return Direction.Right;
                case 40:
                    return Direction.Down;
                case 69:
                    return Direction.End;
                default:
                    Console.WriteLine("\n You need to press one of the arrows. Try again");
                    return TurnsDirection();                   
            }
        }

        public void PlayGame()
        {
            Console.WriteLine("Hello! wellcome to 2048. Play by pressing the key board arrows.\n" +
                " If at any time you wish to end the game, press the letter E. \n Have fun! \n");
            Game thisGame = new Game();
            while(thisGame.CorrentStatus== GameStatus.Idle)
            {
                thisGame.PrintBoard();
                Console.WriteLine("Corrent score: {0}", thisGame.ScoreCount);
                Console.WriteLine("Press E if you wish to end the game. \n");
                thisGame.Move(TurnsDirection());
                if (thisGame.CorrentStatus == GameStatus.Idle)
                {
                    Console.Clear();
                }
                else if (thisGame.CorrentStatus == GameStatus.Lose)
                {
                    Console.Clear();
                    thisGame.PrintBoard();
                    Console.WriteLine("\n Game over:(  You have collected {0} points", thisGame.ScoreCount);
                }
                else if(thisGame.CorrentStatus== GameStatus.Win)
                {
                    Console.WriteLine("Well done! You won the game. You have collected {0} point!", thisGame.ScoreCount);
                }
                else
                {
                    Console.WriteLine("\n You have collected {0} points. Bye!", thisGame.ScoreCount);
                }
            }
        }
    }
}
