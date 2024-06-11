namespace RockPaperScissors;
internal class Game
{
    private const string Rock = "rock";
    private const string Paper = "paper";
    private const string Scissors = "scissors";
    private const string Exit = "exit";
    private const string UserWinMessage = "\u001b[32mYou win!\u001b[0m"; // Change font color to green
    private const string ComputerWinMessage = "\u001b[31mComputer wins!\u001b[0m"; // Change font color to red
    private const string TieMessage = "\u001b[34mIt's a tie!\u001b[0m"; // Change font color to blue

    public static void Run()
    {
        bool playAgain = true;
        Score score = new Score();
        while (playAgain)
        {
            string userInput = GetUserInput();
            string userChoice = ValidateAndConvertInput(userInput);
            if (userChoice == string.Empty)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            if (userChoice == Exit)
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
        score.DisplayScores();
    }

    private static string GetUserInput()
    {
        Console.WriteLine("\nPlease enter rock, paper, scissors, or exit: ");
        return Console.ReadLine()?.ToLower();
    }

    private static string ValidateAndConvertInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        char firstChar = input[0];
        switch (firstChar)
        {
            case 'r':
                return Rock;
            case 'p':
                return Paper;
            case 's':
                return Scissors;
            case 'e':
                return Exit;
            default:
                return string.Empty;
        }
    }

    private static string GetComputerChoice()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 3);

        return randomNumber switch
        {
            0 => Rock,
            1 => Paper,
            2 => Scissors,
            _ => throw new InvalidOperationException("Invalid random number"),
        };
    }

    private static string GetWinner(string userChoice, string computerChoice)
    {
        Console.WriteLine($"\nYou chose {userChoice}");
        DisplayChoice(userChoice);
        Console.WriteLine($"\nComputer chose {computerChoice}");
        DisplayChoice(computerChoice);
        Console.WriteLine("");

        if (userChoice == computerChoice)
        {
            return TieMessage;
        }
        else if ((userChoice == Rock && computerChoice == Scissors) ||
                 (userChoice == Paper && computerChoice == Rock) ||
                 (userChoice == Scissors && computerChoice == Paper))
        {
            return UserWinMessage;
        }
        else
        {
            return ComputerWinMessage;
        }
    }

    private static void UpdateScores(string result, Score score)
    {
        if (result == UserWinMessage)
        {
            score.UserScore++;
        }
        else if (result == ComputerWinMessage)
        {
            score.ComputerScore++;
        }
    }

    private static void DisplayChoice(string choice)
    {
        if (choice == Rock)
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }
        else if (choice == Paper)
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)_____");
            Console.WriteLine("          _______)");
            Console.WriteLine("          ________)");
            Console.WriteLine("         ________)");
            Console.WriteLine("---.____________)");
        }
        else if (choice == Scissors)
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
