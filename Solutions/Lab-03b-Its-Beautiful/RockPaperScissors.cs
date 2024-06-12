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
        bool playAgain = true;
        Score score = new Score();
        while (playAgain)
        {
            string userChoice = GetUserChoice();
            if (userChoice == string.Empty)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            if (userChoice == "exit")
            {
                break;
            }
            string computerChoice = GetComputerChoice();
            string result = GetWinner(userChoice, computerChoice);
            Console.WriteLine(result);
            UpdateScores(result, score);
            score.DisplayScores();
        }

        Console.WriteLine("Thanks for playing!");
        // display the final score
        score.DisplayScores();
    }

    private static string GetUserChoice()
    {
        Console.WriteLine("\nPlease enter rock, paper, scissors, or exit: ");
        string userChoice = Console.ReadLine()?.ToLower();

        if (userChoice == null || userChoice.Length == 0)
        {
            return string.Empty;
        }

        char firstChar = userChoice[0];
        if (firstChar == 'r')
        {
            return "rock";
        }
        else if (firstChar == 'p')
        {
            return "paper";
        }
        else if (firstChar == 's')
        {
            return "scissors";
        }
        else if (firstChar == 'e')
        {
            return "exit";
        }
        else
        {
            return string.Empty;
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
        userChoice = userChoice.ToLower();

        Console.WriteLine($"\nYou chose {userChoice}");
        DisplayChoice(userChoice);
        Console.WriteLine($"\nComputer chose {computerChoice}");
        DisplayChoice(computerChoice);
        Console.WriteLine("");

        if (userChoice == computerChoice)
        {
            return "\u001b[34mIt's a tie!\u001b[0m"; // Change font color to blue
        }
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
        {
            return "\u001b[32mYou win!\u001b[0m"; // Change font color to green
        }
        else
        {
            return "\u001b[31mComputer wins!\u001b[0m"; // Change font color to red
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

    // create a method that will display ascii art of a rock, paper, or scissors
    // based on the user's choice
    private static void DisplayChoice(string choice)
    {
        if (choice == "rock")
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }
        else if (choice == "paper")
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)_____");
            Console.WriteLine("          _______)");
            Console.WriteLine("          ________)");
            Console.WriteLine("         ________)");
            Console.WriteLine("---.____________)");
        }
        else if (choice == "scissors")
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)_____");
            Console.WriteLine("          _______)");
            Console.WriteLine("       ___________)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }
    }
    private class Score
    {
        public int UserScore { get; set; }
        public int ComputerScore { get; set; }
        public void DisplayScores()
        {
            Console.WriteLine($"\nUser Score: {UserScore}, Computer Score: {ComputerScore}");
        }
    }
}
