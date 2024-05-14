using System;
using System.Collections.Generic;
using System.Text;

namespace Play2048
{
    //LeftArrow = 37,
    //UpArrow = 38,
    //RightArrow = 39,
    //DownArrow = 40,
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
                default:
                    Console.WriteLine("You need to press one of the arrows. Try again");
                    return TurnsDirection();                   
            }
        }

        public void PlayGame()
        {

            Game thisGame = new Game();
            thisGame.PrintBoard();
            while(thisGame.CorrentStatus== GameStatus.Idle)
            {
                thisGame.Move(TurnsDirection());
                thisGame.PrintBoard();
            }
        }
    }
}
