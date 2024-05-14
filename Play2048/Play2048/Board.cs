using System;
using System.Collections.Generic;
using System.Text;

namespace Play2048
{
    class Board 
    {
        public int[,] Data { get; protected set; }

        public BoardHelpFunctions HelpFunctions = new BoardHelpFunctions();
        public Board()
        {
            Data = new int[4, 4];
        }
        public void RandomFirstPlaces()
        {
            Random placements = new Random();
            int placedValue = HelpFunctions.GetValueToAdd();
            int xPlace = placements.Next(0, 4);
            int yPlace = placements.Next(0, 4);
            Data[xPlace, yPlace] = placedValue;
            bool secondAdded = false;
            while (!secondAdded)
            {
                int secondPlacedValue = HelpFunctions.GetValueToAdd();
                int secondXPlace = placements.Next(0, 4);
                int secondYPlace = placements.Next(0, 4);
                if (secondXPlace != xPlace || secondYPlace != yPlace)
                {
                    Data[secondXPlace, secondYPlace] = secondPlacedValue;
                    secondAdded = true;
                }
            }
        }

        public int Move(Direction turnsDirection)
        {
            int turnScore = 0;
            if ((int)turnsDirection == 0 )
            {
                turnScore = MoveBoardUp();
            }
            else if ((int)turnsDirection==1)
            {
                turnScore =  MoveBoardDown();
            }
            else if ((int)turnsDirection == 2)
            {
                turnScore =  MoveBoardLeft();
            }
            else
            {
                turnScore = MoveBoardRight();
            }
            if(!HelpFunctions.IsFull(Data))
            {
                HelpFunctions.RandomAdd(Data);
            }
            return turnScore;
        }
        public int MoveBoardUp()
        {
            int turnScore = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Data[i, j] != default)
                    {
                        turnScore += MoveUpOrDown(i, j, 0);
                    }
                }
            }
            return turnScore;
        }

        public int MoveBoardDown()
        {
            int turnScore = 0;
            for (int i = 3; i > -1; i--)
            {
                for (int j = 3; j > -1; j--)
                {
                    if (Data[i, j] != default)
                    {
                        turnScore += MoveUpOrDown(i, j, 1);
                    }
                }
            }
            return turnScore;
        }

        public int MoveBoardLeft()
        {
            int turnScore = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Data[i, j] != default)
                    {
                        turnScore += MoveLeftOrRight(i, j, 2);
                    }
                }
            }
            return turnScore;
        }

        public int MoveBoardRight()
        {
            int turnScore = 0;
            for (int i = 3; i > -1; i--)
            {
                for (int j = 3; j > -1; j--)
                {
                    if (Data[i, j] != default)
                    {
                        turnScore += MoveLeftOrRight(i, j, 3);
                    }
                }
            }
            return turnScore;
        }


        public int MoveUpOrDown(int xPlace, int yPlace, int direction)
        {
            int placementCheck = 3;
            if (direction==0)
            {
                placementCheck = 0;
            }
            for(int i=0; i<4; i++)
            {
                if (xPlace != placementCheck)
                {
                    if (Data[placementCheck, yPlace] == default)
                    {
                        Data[placementCheck, yPlace] = Data[xPlace, yPlace];
                        Data[xPlace, yPlace] = default;
                        return 0;
                    }
                    else if (Data[placementCheck, yPlace] == Data[xPlace, yPlace])
                    {
                        Data[placementCheck, yPlace] += Data[placementCheck, yPlace];
                        Data[xPlace, yPlace] = default;
                        return Data[placementCheck, yPlace];
                    }
                    if(direction==0)
                    {
                        placementCheck++;
                    }
                    else
                    {
                        placementCheck--;
                    }
                }
            }
            return 0;
        }

        public int MoveLeftOrRight(int xPlace, int yPlace, int direction)
        {
            int placementCheck = 3;
            if (direction == 2)
            {
                placementCheck = 0;
            }
            for( int i=0; i<4; i++)
            {
                if (yPlace != placementCheck)
                {
                    if (Data[xPlace, placementCheck] == default)
                    {
                        Data[xPlace, placementCheck] = Data[xPlace, yPlace];
                        Data[xPlace, yPlace] = default;
                        return 0;
                    }
                    else if (Data[xPlace, placementCheck] == Data[xPlace, yPlace])
                    {
                        Data[xPlace, placementCheck] += Data[xPlace, placementCheck];
                        Data[xPlace, yPlace] = default;
                        return Data[xPlace, placementCheck];
                    }
                    if (direction == 2)
                    {
                        placementCheck++;
                    }
                    else
                    {
                        placementCheck--;
                    }
                }
            }
            return 0;
        }
    }
}
