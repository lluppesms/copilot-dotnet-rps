namespace RockPaperScissors.Tests
{
    [TestClass]
    public class RockPaperScissorsTests
    {
        [TestMethod]
        public void ValidateAndConvertInput_ValidInput_ReturnsCorrectChoice()
        {
            // Arrange
            string input = "r";
            Game.Choice expectedChoice = Game.Choice.Rock;

            // Act
            Game.Choice actualChoice = Game.ValidateAndConvertInput(input);

            // Assert
            Assert.AreEqual(expectedChoice, actualChoice);
        }

        [TestMethod]
        public void ValidateAndConvertInput_EmptyInput_ReturnsExitChoice()
        {
            // Arrange
            string input = "";
            Game.Choice expectedChoice = Game.Choice.Exit;

            // Act
            Game.Choice actualChoice = Game.ValidateAndConvertInput(input);

            // Assert
            Assert.AreEqual(expectedChoice, actualChoice);
        }

        [TestMethod]
        public void ValidateAndConvertInput_InvalidInput_ReturnsExitChoice()
        {
            // Arrange
            string input = "x";
            Game.Choice expectedChoice = Game.Choice.Exit;

            // Act
            Game.Choice actualChoice = Game.ValidateAndConvertInput(input);

            // Assert
            Assert.AreEqual(expectedChoice, actualChoice);
        }

        [TestMethod]
        public void GetWinner_UserWins_ReturnsYouWin()
        {
            // Arrange
            Game.Choice userChoice = Game.Choice.Rock;
            Game.Choice computerChoice = Game.Choice.Scissors;
            string expected = "\u001b[32mYou win!\u001b[0m";

            // Act
            string result = Game.GetWinner(userChoice, computerChoice);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetWinner_ComputerWins_ReturnsComputerWins()
        {
            // Arrange
            Game.Choice userChoice = Game.Choice.Rock;
            Game.Choice computerChoice = Game.Choice.Paper;
            string expected = "\u001b[31mComputer wins!\u001b[0m";

            // Act
            string result = Game.GetWinner(userChoice, computerChoice);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetWinner_Tie_ReturnsTie()
        {
            // Arrange
            Game.Choice userChoice = Game.Choice.Rock;
            Game.Choice computerChoice = Game.Choice.Rock;
            string expected = "\u001b[34mIt's a tie!\u001b[0m";

            // Act
            string result = Game.GetWinner(userChoice, computerChoice);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UpdateScores_UserWins_IncrementsUserScore()
        {
            // Arrange
            Score score = new Score();
            string result = "\u001b[32mYou win!\u001b[0m";

            // Act
            Game.UpdateScores(result, score);

            // Assert
            Assert.AreEqual(1, score.UserScore);
        }

        [TestMethod]
        public void UpdateScores_ComputerWins_IncrementsComputerScore()
        {
            // Arrange
            Score score = new Score();
            string result = "\u001b[31mComputer wins!\u001b[0m";

            // Act
            Game.UpdateScores(result, score);

            // Assert
            Assert.AreEqual(1, score.ComputerScore);
        }
    }
}