namespace RockPaperScissors;

public class Score
{
    /// <summary>
    /// Gets or sets the score of the user.
    /// </summary>
    public int UserScore { get; set; }

    /// <summary>
    /// Gets or sets the score of the computer.
    /// </summary>
    public int ComputerScore { get; set; }

    /// <summary>
    /// Displays the current scores of the user and the computer.
    /// </summary>
    public void DisplayScores()
    {
        Console.WriteLine($"\nUser Score: {UserScore}, Computer Score: {ComputerScore}");
    }
}
