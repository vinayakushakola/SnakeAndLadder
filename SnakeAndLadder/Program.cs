using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Welcome To Snake And Ladder Game ================");
            clsSnakeAndLadder clsSnakeAndLadder = new clsSnakeAndLadder();
            clsSnakeAndLadder.StartGame();
        }
    }
}
