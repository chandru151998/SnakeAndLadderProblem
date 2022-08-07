using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class RandomNumber
    {
        public static void RollTheDie()
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            Console.WriteLine("Random Number is " + dice);
        }
    }
}