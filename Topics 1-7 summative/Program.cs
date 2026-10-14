namespace Topics_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;
            string RPS;
            Console.WriteLine("Rock Paper Scissors");
            RPS = Console.ReadLine();
            randNum = generator.Next(2);
            if (randNum == 0)
            {
                Console.WriteLine("Rock");
                if (RPS.ToLower() == "rock")
                {
                    Console.WriteLine("It's a tie");
                }
                if (RPS.ToLower() == "paper")
                {
                    Console.WriteLine("You lose!");
                }
                if (RPS.ToLower() == "scissors")
                {
                    Console.WriteLine("You win!");
                }
            }
            if (randNum == 1)
            {
                Console.WriteLine("Paper");
                if (RPS.ToLower() == "rock")
                {
                    Console.WriteLine("You lose!");
                }
                if (RPS.ToLower() == "paper")
                {
                    Console.WriteLine("It's a tie!");
                }
                if (RPS.ToLower() == "scissors")
                {
                    Console.WriteLine("You win!");
                }
            }
            if (randNum == 2)
            {
                Console.WriteLine("Scissors");
                if (RPS.ToLower() == "rock")
                {
                    Console.WriteLine("You win!");
                }
                if (RPS.ToLower() == "paper")
                {
                    Console.WriteLine("You lose!");
                }
                if (RPS.ToLower() == "scissors")
                {
                    Console.WriteLine("It's a tie");
                }
            }
        }
    }
}
