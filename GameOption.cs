using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class GameOption
    {
		const int NO_PLAY = 0;
		const int PLAY = 1;
		const int SNEAK = 3;
		const int LADDER = 5;

		public static void CheckOption()
		{
            int startPoint = 0;
            int ladderEnd = 22;

            Random random = new Random();
            int check = random.Next(2);
            Console.WriteLine("Got : " + check);

            switch (check)
            {
                case NO_PLAY:
                    startPoint = 0;
                    Console.WriteLine("You got 0, so position: " + startPoint);
                    break;
                case PLAY:

                    int roll = (random.Next(1, 6) + 1);
                    Console.WriteLine("roll : " + roll);
                    switch (roll)
                    {
                        case SNEAK:
                            startPoint -= roll;
                            Console.WriteLine("You got a sneak, so your position will be same a before." + startPoint);

                            break;

                        case LADDER:
                            startPoint = ladderEnd + roll;
                            Console.WriteLine("You got a ladder, so your new poition: " + startPoint);
                            break;

                        default:
                            startPoint += roll;
                            Console.WriteLine("Your position: " + startPoint);
                            if (roll == 6)
                                Console.WriteLine("You got 6 so, play again.");
                            break;
                    }
                    break;


            }
        }
	}
}