using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class ReportOfTwoPlayers
    {
        public static void TwoPlayers()
        {
            const int ladder = 5;
            const int noLadder = 6;
            const int playerOne = 10;
            const int playerTwo = 11;
            int winposition = 1;
            Random random = new Random();
            int dice = random.Next(10, 12);
            Console.WriteLine("Player " + dice + " plays the game");
            if (dice == playerOne)
            {
                Random num = new Random();
                int val = num.Next(5, 7);
                Console.WriteLine(val);
                if (val == ladder)
                {
                    Console.WriteLine("Player 10 plays again");
                }
                else
                {
                    Console.WriteLine("Player 10 stops playing");

                }
            }
            else
            {
                Random value = new Random();
                int ram = value.Next(5, 7);
                Console.WriteLine(ram);
                if (ram == ladder)
                {
                    Console.WriteLine("Player 11 plays again");
                }
                else
                {
                    Console.WriteLine("Player 11 stops playing");
                }
            }
            Random win = new Random();
            int winPoint = win.Next(0, 7);
            Console.WriteLine("Dice Number is : " + winPoint);
            if (winPoint == winposition)
            {
                Console.WriteLine("Player reached the winning position");
            }
            else
            {
                Console.WriteLine("No player reached winning position");
            }
        }
    }
}