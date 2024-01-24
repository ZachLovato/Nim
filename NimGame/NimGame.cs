using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NimGame
{
    internal class NimGame
    {
        public bool isGameOver;
        public bool isPlayerOneTurn = true;
        private int[,] pegs = new int[1,4] { {1,3,5,7 } };

        public void switchPlayerTurn()
        {
            checkGameEnd();
            if(isGameOver == false)
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
                Console.WriteLine("Game Has Ended");
                Window end = new WinWindow(isPlayerOneTurn);
                end.Show();
            }
        }

        public void checkGameEnd()
        {
            if(pegsRemaining() == 0)
            {
                isGameOver = true;
            }
        }

        public void removePegs(int index)
        {
            if (pegs[0,index] > 0)
            {
                pegs[0,index]--;
            }
        }

        public int pegsRemaining()
        {
            int totalPegs = 0;
            for(int i = 0; i < 4; i++)
            {
                totalPegs += pegs[0,i];
            }
            return totalPegs;
        }

        public bool GetGameEnd()
        {
            return isGameOver;
        }

        public bool GetPlayerTurn()
        {
            return isPlayerOneTurn;
        }

    }
}
