using System;
using System.Collections.Generic;
using System.Text;

namespace Play2048
{
    class BoardHelpFunctions
    {
        public bool IsFull(int[,] data)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[i, j] == default)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool WinAlready(int[,] data)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[i, j] == 2048)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetValueToAdd()
        {
            Random placements = new Random();
            int randomValue = placements.Next(2, 5);
            if (randomValue == 3)
            {
                return GetValueToAdd();
            }
            return randomValue;
        }

        public void RandomAdd(int[,] data)
        {
            Random placements = new Random();
            int xPlace = placements.Next(0, 4);
            int yPlace = placements.Next(0, 4);
            if (data[xPlace, yPlace] == default)
            {
                data[xPlace, yPlace] = GetValueToAdd();
            }
            else
            {
                RandomAdd(data);
            }
        }
    }
}
