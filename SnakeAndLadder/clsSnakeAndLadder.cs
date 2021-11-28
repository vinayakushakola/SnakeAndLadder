using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class clsSnakeAndLadder
    {
        private int PlayerPosition; // Default Value = 0
        private int RolledDie;      // Default Value = 0

        public void StartGame()
        {
            PrintPlayerPosition();
            RollADie();
            PrintPlayerPosition();
        }

        private void RollADie()
        {
            Random generateNum = new Random();
            RolledDie = generateNum.Next(7);
            PlayerPosition += RolledDie; 
            Console.WriteLine("Rolled Die: {0}", RolledDie);
        }

        private void PrintPlayerPosition()
        {
            Console.WriteLine("Player Position: {0}", PlayerPosition);
        }
    }
}
