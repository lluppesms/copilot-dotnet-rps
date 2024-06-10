namespace RockPaperScissors;
internal class RockPaperScissors
{
    // create a rock paper scissors game
    // 1. ask user to input rock paper or scissors
    // 2. have the computer select a random choice
    // 3. compare the two choices and send out the results
    // 4. ask the user if they want to play again

    public static void Main()
    {
        Console.WriteLine("Welcome to Rock Paper Scissors!");
        bool playAgain = true;
        while (playAgain)
        {
            Console.WriteLine("Please enter rock, paper, or scissors: ");
            string userChoice = Console.ReadLine();
            string computerChoice = GetComputerChoice();
            Console.WriteLine($"Computer chose {computerChoice}");
            string result = GetWinner(userChoice, computerChoice);
            Console.WriteLine(result);
            Console.WriteLine("Do you want to play again? (yes/no)");
            string answer = Console.ReadLine();
            if (answer != "yes")
            {
                playAgain = false;
            }
        }


    }
}
