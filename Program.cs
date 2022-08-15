using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber,
                computerRandomNumber,
                playerScore = 0,
                computerScore = 0;


            Random random = new Random();
            Console.WriteLine("Welcome to the Dice Game, Have fun!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Press enter or any key to roll the dice!");

                Console.ReadLine();

                Console.WriteLine(" Your turn...");
                System.Threading.Thread.Sleep(1000);

                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine("On This turn your number is " + playerRandomNumber);

                Console.WriteLine("PC AI turn...");
                System.Threading.Thread.Sleep(1000);

                computerRandomNumber = random.Next(1, 7);
                Console.WriteLine("Computer AI on this turn rolled a number " + computerRandomNumber);

                if (playerRandomNumber > computerRandomNumber)
                {
                    playerScore++;
                    Console.WriteLine("Player wins this round!!");
                }
                else if (playerRandomNumber < computerRandomNumber)
                {
                    computerScore++;
                    Console.WriteLine("Computer AI wins this round!!");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("The current general score - Player : " + playerScore + " Computer AI : " + computerScore + " !!");
                Console.WriteLine();
            }

            if (playerScore > computerScore)
            {
                Console.WriteLine("You win, Congrats!!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("You loose, Try again!!");
            }

            else
            {

                Console.WriteLine("Draw , ): ");

            }

            Console.ReadLine();

        }
    }
}
