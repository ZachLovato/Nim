﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    internal class NimGame
    {
        public bool isGameOver;
        public bool isPlayerOneTurn;
        private int[1][] pegs;

        public void switchPlayerTurn()
        {
            if(checkGameEnd == false)
            {
                if(!isPlayerOneTurn)
                {
                    isPlayerOneTurn = true;
                }
                else
                {
                    isPlayerOneTurn = false;
                }
            }
            else
            {
                //go to win screen
            }
        }

        public void checkGameEnd()
        {
            if(pegsRemaining == 0)
            {
                isGameOver = true;
            }
        }

        public void removePegs(int index)
        {
            if (pegs[0][index] > 0)
            {
                pegs[0][index]--;
            }
        }

        public int pegsRemaining(int index)
        {
            int totalPegs = 0;
            for(int i = 0; i < pegs[0].length; i++)
            {
                totalPegs += pegs[0][index];
            }
            return totalPegs;
        }
    }
}
