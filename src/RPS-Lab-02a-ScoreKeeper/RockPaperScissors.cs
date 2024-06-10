namespace RockPaperScissors;
internal class Game
{
    // create a rock paper scissors game
    // 1. ask user to input rock paper or scissors
    // 2. have the computer select a random choice
    // 3. compare the two choices and send out the results
    // 4. ask the user if they want to play again

    // Add a Score class to keep track of the scores
    public static void Run()
    {
        Console.WriteLine("Welcome to Rock Paper Scissors!");
        bool playAgain = true;
        Score score = new Score(); // Create a Score instance
        while (playAgain)
        {
            Console.WriteLine("Please enter rock, paper, or scissors: ");
            string userChoice = Console.ReadLine();
            string computerChoice = GetComputerChoice();
            Console.WriteLine($"Computer chose {computerChoice}");
            string result = GetWinner(userChoice, computerChoice);
            Console.WriteLine(result);
            UpdateScores(result, score); // Update the scores
            score.DisplayScores(); // Display the scores
            Console.WriteLine("Do you want to play again? (yes/no)");
            string answer = Console.ReadLine();
            if (answer != "yes")
            {
                playAgain = false;
            }
        }
    }
    private static void UpdateScores(string result, Score score)
    {
        if (result == "You win!")
        {
            score.UserScore++;
        }
        else if (result == "Computer wins!")
        {
            score.ComputerScore++;
        }
    }
    private static string GetComputerChoice()
    {
        // generate a random number between 0 and 2
        Random random = new Random();
        int randomNumber = random.Next(0, 3);

        // map the random number to rock, paper, or scissors
        string computerChoice = randomNumber switch
        {
            0 => "rock",
            1 => "paper",
            2 => "scissors",
            _ => throw new InvalidOperationException("Invalid random number"),
        };

        return computerChoice.ToLower(); // convert computer choice to lowercase
    }
    private static string GetWinner(string userChoice, string computerChoice)
    {
        userChoice = userChoice.ToLower(); // convert user choice to lowercase

        if (userChoice == computerChoice)
        {
            return "It's a tie!";
        }
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
        {
            return "You win!";
        }
        else
        {
            return "Computer wins!";
        }
    }
    private class Score
    {
        public int UserScore { get; set; }
        public int ComputerScore { get; set; }
        public void DisplayScores()
        {
            Console.WriteLine($"User Score: {UserScore}, Computer Score: {ComputerScore}");
        }
    }
}
