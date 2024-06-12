# Rock Paper Scissors Game

This is a console application that allows a user to play the game of Rock, Paper, Scissors against the computer.

## Files in the Solution

### RockPaperScissors.cs

This file contains the `Game` class which manages the game logic. It includes methods for:

- `Run()`: This is the main method that runs the game. It gets the user's and computer's choices, determines the winner, updates the scores, and displays the scores.
- `GetUserInput()`: This method gets the user's choice.
- `ValidateAndConvertInput(string input)`: This method validates and converts the user's input into a `Choice` enum.
- `GetComputerChoice()`: This method randomly selects a choice for the computer.
- `GetWinner(Choice userChoice, Choice computerChoice)`: This method determines the winner of the game based on the user's and computer's choices.
- `UpdateScores(string result, Score score)`: This method updates the scores based on the result of the game.
- `DisplayChoice(Choice choice)`: This method displays the chosen option.

### Score.cs

This file contains the `Score` class which is used to keep track of the scores. It includes:

- `UserScore`: This property keeps track of the user's score.
- `ComputerScore`: This property keeps track of the computer's score.
- `DisplayScores()`: This method displays the current scores of the user and the computer.

## How to Run

To run the game, simply compile and run the solution. The game will prompt you to enter a choice of rock, paper, or scissors, or to exit the game. After each round, the game will display the current scores and ask if you want to play again.
