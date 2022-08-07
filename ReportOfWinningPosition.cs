using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class ReportOfWinningPosition
    {
        public static void WinPoint()
        {
            const int winningPoint = 1;
            Random random = new Random();
            int dice = random.Next(7);
            Console.WriteLine("Dice Number is : " + dice);
            if (dice == winningPoint)
            {
                Console.WriteLine("Player reached the winning position");
            }
            else
            {
                Console.WriteLine("Player stays at same position");
            }
        }
    }
}