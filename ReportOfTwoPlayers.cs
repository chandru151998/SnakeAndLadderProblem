using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class ReportOfTwoPlayers
    {
        static int DiceNum;
        static int positionA = 0;
        static int positionB = 0;
        static int countA = 0;
        static int countB = 0;

        public static void TwoPlayers()
        {
            Console.WriteLine("Starting game in Multiplayer Player Mode");
            Console.WriteLine("Starting Player A at position " + positionA);
            Console.WriteLine("Starting Player B at position " + positionB);
            player();
        }
        public static void player()
        {
            while (positionA != 100 && positionB != 100)
            {
                rollsDiceA();
                rollsDiceB();
            }
            if (positionA == 100)
                Console.WriteLine("Player A Wins");
            else
                Console.WriteLine("Player B Wins");
        }

        public static void rollsDiceA()
        {
            ++countA;
            Random random = new Random();
            int choice = random.Next(3);

            if (choice == 0)                          //No Play
            {
                Console.WriteLine("No PLay");
                Console.WriteLine("Initial Position is " + positionA);
            }
            else if (choice == 1)                      //Ladder found
            {
                Console.WriteLine("Ladder is found");
                DiceNum = random.Next(6);
                positionA += DiceNum;
                Console.WriteLine("Initial Position is " + positionA);
            }
            else                                        //Snake found
            {
                Console.WriteLine("Snake is found");
                DiceNum = random.Next(6);
                positionA -= DiceNum;
                Console.WriteLine("Initial Position is " + positionA);
            }
            //in case position lessthan 0, position will be set to 0
            if (positionA < 0)
            {
                positionA = 0;
            }
            //in case position greaterthan 100, then position will be set back to its previous position
            if (positionA > 100)
            {
                positionA -= DiceNum;
            }
            //In case Player reaches the end.
            if (positionA == 100)
            {
                Console.WriteLine("Wou Win");
                Console.WriteLine("No. of times Dice rolled = " + countA);
            }
            Console.WriteLine("Current Position " + positionA);
        }

        public static void rollsDiceB()
        {
            ++countB;
            Random random = new Random();
            int choice = random.Next(3);

            if (choice == 0)                          //No Play
            {
                Console.WriteLine("No PLay");
                Console.WriteLine("Initial Position is " + positionB);
            }
            else if (choice == 1)                      //Ladder found
            {
                Console.WriteLine("Ladder is found");
                DiceNum = random.Next(6);
                positionB += DiceNum;
                Console.WriteLine("Initial Position is " + positionB);
            }
            else                                        //Snake found
            {
                Console.WriteLine("Snake is found");
                DiceNum = random.Next(6);
                positionB -= DiceNum;
                Console.WriteLine("Initial Position is " + positionB);
            }
            //in case position lessthan 0, position will be set to 0
            if (positionB < 0)
            {
                positionB = 0;
            }
            //in case position greaterthan 100, then position will be set back to its previous position
            if (positionB > 100)
            {
                positionB -= DiceNum;
            }
            //In case Player reaches the end.
            if (positionB == 100)
            {
                Console.WriteLine("Wou Win");
                Console.WriteLine("No. of times Dice rolled = " + countB);
            }
            Console.WriteLine("Current Position " + positionB);
        }
    }
}