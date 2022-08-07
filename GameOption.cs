using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class GameOption
    {
		public static void CheckOption()
		{
			{
				Random random = new Random();
				int check = random.Next(3);
				Console.WriteLine("Dice Number is " + check);
				if (check == 0)
				{
					Console.WriteLine("No Play and Player stays in the same position");
				}
				else if (check == 1)
				{
					Console.WriteLine("Ladder : Move ahead by the number of position received in the die");
				}
				else
                {
					Console.WriteLine("Snake : Move behind by the number of position received in the die");

				}
			}
		}
	}
}