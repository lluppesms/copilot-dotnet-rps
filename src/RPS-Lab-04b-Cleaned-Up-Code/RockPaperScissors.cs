namespace RockPaperScissors;
internal class Game
{
    private enum Choice
    {
        Rock,
        Paper,
        Scissors,
        Exit
    }

    private const string YouWin = "\u001b[32mYou win!\u001b[0m";
    private const string ComputerWins = "\u001b[31mComputer wins!\u001b[0m";
    private const string Tie = "\u001b[34mIt's a tie!\u001b[0m";

    /// <summary>
    /// Runs the Rock-Paper-Scissors game.
    /// </summary>
    public static void Run()
    {
        bool playAgain = true;
        Score score = new Score();
        while (playAgain)
        {
            string userInput = GetUserInput();
            Choice userChoice = ValidateAndConvertInput(userInput);
            if (userChoice == Choice.Exit)
            {
                break;
            }
            Choice computerChoice = GetComputerChoice();
            string result = GetWinner(userChoice, computerChoice);
            Console.WriteLine(result);
            UpdateScores(result, score);
            score.DisplayScores();
        }

        Console.WriteLine("Thanks for playing!");
        score.DisplayScores();
    }

    /// <summary>
    /// Gets the user input for the Rock-Paper-Scissors game.
    /// </summary>
    /// <returns>The user input.</returns>
    private static string GetUserInput()
    {
        Console.WriteLine($"\nPlease enter {Choice.Rock}, {Choice.Paper}, {Choice.Scissors}, or {Choice.Exit}: ");
        return Console.ReadLine()?.ToLower();
    }

    /// <summary>
    /// Validates and converts the user input to the corresponding Choice enum value.
    /// </summary>
    /// <param name="input">The user input.</param>
    /// <returns>The Choice enum value corresponding to the user input.</returns>
    private static Choice ValidateAndConvertInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return Choice.Exit;
        }

        char firstChar = input[0];
        return firstChar switch
        {
            'r' => Choice.Rock,
            'p' => Choice.Paper,
            's' => Choice.Scissors,
            'e' => Choice.Exit,
            _ => Choice.Exit,
        };
    }

    /// <summary>
    /// Generates a random choice for the computer.
    /// </summary>
    /// <returns>The randomly generated Choice enum value.</returns>
    private static Choice GetComputerChoice()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 3);
        return (Choice)randomNumber;
    }

    /// <summary>
    /// Determines the winner of the Rock-Paper-Scissors game based on the user's choice and the computer's choice.
    /// </summary>
    /// <param name="userChoice">The user's choice.</param>
    /// <param name="computerChoice">The computer's choice.</param>
    /// <returns>A string indicating the winner of the game.</returns>
    private static string GetWinner(Choice userChoice, Choice computerChoice)
    {
        Console.WriteLine($"\nYou chose {userChoice}");
        DisplayChoice(userChoice);
        Console.WriteLine($"\nComputer chose {computerChoice}");
        DisplayChoice(computerChoice);
        Console.WriteLine("");

        if (userChoice == computerChoice)
        {
            return Tie;
        }
        else if ((userChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                 (userChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                 (userChoice == Choice.Scissors && computerChoice == Choice.Paper))
        {
            return YouWin;
        }
        else
        {
            return ComputerWins;
        }
    }

    /// <summary>
    /// Updates the scores based on the result of the game.
    /// </summary>
    /// <param name="result">The result of the game.</param>
    /// <param name="score">The score object to update.</param>
    private static void UpdateScores(string result, Score score)
    {
        if (result == YouWin)
        {
            score.UserScore++;
        }
        else if (result == ComputerWins)
        {
            score.ComputerScore++;
        }
    }

    /// <summary>
    /// Displays the ASCII art representation of the chosen option.
    /// </summary>
    /// <param name="choice">The chosen option.</param>
    private static void DisplayChoice(Choice choice)
    {
        switch (choice)
        {
            case Choice.Rock:
                Console.WriteLine("    _______");
                Console.WriteLine("---'   ____)");
                Console.WriteLine("      (_____)");
                Console.WriteLine("      (_____)");
                Console.WriteLine("      (____)");
                Console.WriteLine("---.__(___)");
                break;
            case Choice.Paper:
                Console.WriteLine("    _______");
                Console.WriteLine("---'   ____)_____");
                Console.WriteLine("          _______)");
                Console.WriteLine("          ________)");
                Console.WriteLine("         ________)");
                Console.WriteLine("---.____________)");
                break;
            case Choice.Scissors:
                Console.WriteLine("    _______");
                Console.WriteLine("---'   ____)_____");
                Console.WriteLine("          _______)");
                Console.WriteLine("       ___________)");
                Console.WriteLine("      (____)");
                Console.WriteLine("---.__(___)");
                break;
        }
    }
}
