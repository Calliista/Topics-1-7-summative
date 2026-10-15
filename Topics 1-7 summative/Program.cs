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
            string RPS, bankAcc;
            double bet;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("There's three rounds. if you tie, you try again.");
            rounds = 0;
            points = 0;
            while (rounds != 3)
            {
                RPS = Console.ReadLine();
                randNum = generator.Next(3);
                if (randNum == 0)
                {
                    Console.WriteLine("Rock");
                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine("You lose!");
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    randNum = generator.Next(2);
                }
                if (randNum == 1)
                {
                    Console.WriteLine("Paper");
                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine("You lose!");
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    randNum = generator.Next(2);
                }
                if (randNum == 2)
                {
                    Console.WriteLine("Scissors");
                    rounds = rounds + 1;
                    if (RPS.ToLower() == "rock")
                    {
                        Console.WriteLine("You win!");
                        points = points + 1;
                    }
                    if (RPS.ToLower() == "paper")
                    {
                        Console.WriteLine("You lose!");
                    }
                    if (RPS.ToLower() == "scissors")
                    {
                        Console.WriteLine("It's a tie. Try again.");
                        rounds = rounds - 1;
                    }
                    randNum = generator.Next(2);
                }
                //while (RPS.ToLower() != "rock" || RPS.ToLower() != "paper" || RPS.ToLower() != "scissors")
                //{
                    //Console.WriteLine("type 'rock' 'paper' or 'scissors'");
                    //Console.ReadLine();
                //}
            }
            Console.WriteLine("You won " + points + "/3 rounds.");
            Console.WriteLine();
            Console.WriteLine();
            }
        }
    }

