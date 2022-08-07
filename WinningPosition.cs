using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    internal class WinningPosition
    {
        public static void WinOrRestart()
        {
            const int zeroPosition = 0;
            const int nonZeroPosition = 1;
            Random random = new Random();
            int dice = random.Next(2);
            Console.WriteLine("Dice : "+ dice);
            if (dice == nonZeroPosition)
            {
                Console.WriteLine("Player reached winning point");
            }
            else if (dice == zeroPosition)
            {
                Console.WriteLine("Player has to restart the game");
            }
        }
    }
}