using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class clsSnakeAndLadder
    {
        private int PlayerPosition; // Default Value = 0
        private int RolledDie;      // Default Value = 0
        private Random generateNum;
        private Dictionary<int, int> dictSnakePos;
        private Dictionary<int, int> dictLadders;
        private int NoOfTimesDiceRolled;

        public clsSnakeAndLadder()
        {
            generateNum = new Random();
            dictSnakePos = new Dictionary<int, int>()
            {
                {11,1}, {23,1}, {36, 1}, {58, 1}, {77, 1}, {82, 1}, {89, 1}, {96, 1}, {99, 1}
            };
            dictLadders = new Dictionary<int, int>()
            {
                {5, 1}, {15, 1}, {34, 1}, {48, 1}, {67, 1}, {79, 1}, {83, 1}
            };
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            PrintPlayerPosition();
            bool startGame = true;
            while (startGame)
            {
                RollADie();
                CheckLadderOrSnake();
                if (CheckWonOrNot())
                    startGame = false;
                PrintPlayerPosition();
            }
            Console.WriteLine("No of times dice rolled to win the game: {0}", NoOfTimesDiceRolled);
            Console.WriteLine("Player Won!");
        }

        private void RollADie()
        {
            RolledDie = generateNum.Next(7);
            PlayerPosition += RolledDie; 
            Console.WriteLine("Rolled Die: {0}", RolledDie);
            NoOfTimesDiceRolled++;
        }

        private void PrintPlayerPosition()
        {
            Console.WriteLine("Player Position: {0}", PlayerPosition);
        }

        private void CheckLadderOrSnake()
        {
            int ladder, snakeBite;
            dictLadders.TryGetValue(PlayerPosition, out ladder);
            if (ladder > 0)
            {
                PrintPlayerPosition();
                Console.WriteLine("Ladder: +{0}", RolledDie);
                PlayerPosition += RolledDie;
            }
            dictSnakePos.TryGetValue(PlayerPosition, out snakeBite);
            if (snakeBite > 0)
            {
                PrintPlayerPosition();
                Console.WriteLine("Snake Bite : -{0}", RolledDie);
                PlayerPosition -= RolledDie;
            }
        }

        private bool CheckWonOrNot()
        {
            if (PlayerPosition > 100)
            {
                Console.WriteLine("Rolled bigger number");
                PlayerPosition -= RolledDie;
            }
            else if (PlayerPosition == 100)
            {
                return true;
            }
            return false;
        }
    }
}
