using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool GameOver = false;
            int TotalWins = 0;
            int ComputerWins = 0;

            while (!GameOver)
            {
                bool GameState = PlayGame();
                if (GameState)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Player wins!");
                    TotalWins++;

                    if (TotalWins == 1)
                    {
                        Console.WriteLine("Player has won " + TotalWins + " game!");
                    }
                    else
                    {
                        Console.WriteLine("Player has won " + TotalWins + " games!");
                    }
                }
                else if (!GameState)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Computer wins!");
                    ComputerWins++;

                    if (ComputerWins == 1)
                    {
                        Console.WriteLine("Computer has won " + ComputerWins + " game!");
                    }
                    else
                    {
                        Console.WriteLine("Computer has won " + ComputerWins + " games!");
                    }
                }
                string PlayAgain = "";
                while (PlayAgain != "y" && PlayAgain != "n")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Would you like to play again? Y/N");
                    PlayAgain = Console.ReadLine().ToLower();
                    if (PlayAgain == "n")
                    {
                        GameOver = true;
                        Console.Clear();
                        Console.WriteLine("Thanks for playing! Goodbye!");
                    }
                    else if (PlayAgain != "y" && PlayAgain != "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid option!");
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
        }

        static bool PlayGame()
        {
            int PlayerWins = 0;
            int ComputerWins = 0;

            while (PlayerWins != 3 && ComputerWins != 3)
            {
                Console.WriteLine("Player score: " + PlayerWins + " Computer score: " + ComputerWins);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Rock, Paper or Scissors?");
                string PlayerInput = Console.ReadLine().ToLower();

                Random random = new Random();
                int RandomComputerInput = random.Next(1, 4);

                string ComputerInput = "";
                switch (RandomComputerInput)
                {
                    case 1:
                        ComputerInput = "rock";
                        break;

                    case 2:
                        ComputerInput = "paper";
                        break;

                    case 3:
                        ComputerInput = "scissors";
                        break;

                }

                Console.Clear();
                if (PlayerInput == ComputerInput)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (PlayerInput != "rock" && PlayerInput != "paper" && PlayerInput != "scissors")
                {
                    Console.WriteLine("Please enter a valid option!");
                }

                else if (PlayerInput == "rock" && ComputerInput == "scissors")
                {
                    Console.WriteLine("Rock beats scissors! Player wins a point!");
                    PlayerWins++;
                }
                else if (PlayerInput == "paper" && ComputerInput == "rock")
                {
                    Console.WriteLine("Paper beats rock! Player wins a point!");
                    PlayerWins++;
                }
                else if (PlayerInput == "scissors" && ComputerInput == "paper")
                {
                    Console.WriteLine("Scissors beats paper! Player wins a point!");
                    PlayerWins++;
                }

                else if (PlayerInput == "rock" && ComputerInput == "paper")
                {
                    Console.WriteLine("Paper beats rock! Computer wins a point!");
                    ComputerWins++;
                }
                else if (PlayerInput == "paper" && ComputerInput == "scissors")
                {
                    Console.WriteLine("Scissors beats paper! Computer wins a point!");
                    ComputerWins++;
                }
                else if (PlayerInput == "scissors" && ComputerInput == "rock")
                {
                    Console.WriteLine("Rock beats scissors! Computer wins a point!");
                    ComputerWins++;
                }
            }
            if (PlayerWins == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}