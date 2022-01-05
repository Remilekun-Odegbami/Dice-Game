using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNumber;

            int playerPoints = 0;
            int aiPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
			{
            Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();
                Console.WriteLine();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a {0}", playerRandomNum);

                Console.WriteLine("_______");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine("AI rolled a {0}" , enemyRandomNumber);


            if(playerRandomNum > enemyRandomNumber)
                {
                    playerPoints++;
                    Console.WriteLine("Player won this round");
                } else if(enemyRandomNumber > playerRandomNum)
                {
                    aiPoints++;
                    Console.WriteLine("AI won this round");
                }
            else
                {
                    Console.WriteLine("There is a draw!");
                }
                Console.WriteLine("Final score is- Player : {0}, AI : {1} ", playerPoints, aiPoints);
                Console.WriteLine();
			}

            if(playerPoints > aiPoints)
            {
                Console.WriteLine("Congratulations, you won!");
            } else if(aiPoints > playerPoints)
            {
                Console.WriteLine("Sorry, you lost. AI won!");
            } else
            {
                Console.WriteLine("It's a draw!!!");
            }

            Console.ReadKey();
        }
    }
}
