using System.Net.NetworkInformation;

namespace Topics_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            int randNum, rounds, points;
            string RPS = "", yn;
            double bet, bankAcc;
            bool done, retry;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("There's three rounds. if you tie, you try again.");
            Console.WriteLine("You have $50.00 in your bank account");
            bet = 0.0;
            Console.WriteLine("Enter the ammount you're betting: ");
            bet = Convert.ToInt32(Console.ReadLine());
            bankAcc = 50.00;
            rounds = 0;
            points = 0;
            //retry = false;
            //while (!retry) 
            //{  
            while (rounds != 3)
            {
                done = false;
                while (!done)
                {
                    Console.WriteLine("type 'rock' 'paper' or 'scissors'");
                    RPS = Console.ReadLine();
                    if (RPS.ToLower() == "rock" || RPS.ToLower() == "paper" || RPS.ToLower() == "scissors")
                    {
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }

                randNum = generator.Next(3);
                if (randNum == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Rock");
                    Console.WriteLine("      _______");
                    Console.WriteLine("-- - '   ____");
                    Console.WriteLine("      (_____)");
                    Console.WriteLine("      (_____)");
                    Console.WriteLine("      (____)");
                    Console.WriteLine("-- -.__(___)");

                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!");
                    }
                    randNum = generator.Next(2);
                }
                if (randNum == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Paper");
                    Console.WriteLine("      _______");
                    Console.WriteLine("-- - '   ____)_____");
                    Console.WriteLine("          ________)");
                    Console.WriteLine("          _________)");
                    Console.WriteLine("         _________)");
                    Console.WriteLine("---.____________)");

                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!");
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    randNum = generator.Next(2);
                }
                if (randNum == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Scissors");
                    Console.WriteLine("      _______");
                    Console.WriteLine("-- - '   ____)____");
                    Console.WriteLine("          _______)");
                    Console.WriteLine("       ___________)");
                    Console.WriteLine("      (____)");
                    Console.WriteLine("-- -.__(___)");

                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lose!");
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine();
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    randNum = generator.Next(2);
                }

            }
            Console.WriteLine();
            Console.WriteLine("You won " + points + "/3 rounds.");
            if (points <= 1)
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("You lost " + bet.ToString("C"));
                bankAcc = bankAcc - bet;
                Console.WriteLine("You now have " + bankAcc.ToString("C") + " in your bank account");
                Console.WriteLine();
                Console.WriteLine("Would you like to try again? (yes/no)");
                yn = Console.ReadLine();
                if (yn.ToLower() == "yes")
                {
                    Console.WriteLine();
                }
                if (yn.ToLower() == "no")
                {
                    Console.WriteLine();
                }
                if (points >= 2)
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine("You won " + bet.ToString("C"));
                    bankAcc = bankAcc + bet;
                    Console.WriteLine("You now have " + bankAcc.ToString("C") + " in your bank account");
                    Console.WriteLine("Would you like to try again? (yes/no)");
                    yn = Console.ReadLine();
                    if (yn.ToLower() == "yes")
                    {
                        Console.WriteLine();
                    }
                    if (yn.ToLower() == "no")
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}

