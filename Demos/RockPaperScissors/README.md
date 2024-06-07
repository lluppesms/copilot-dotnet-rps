# Getting started - Visual Studio IDE

Welcome to GitHub Copilot! In this example, we'll show you how to use Copilot to write a simple .NET application.

## Prerequisites

Make sure that you meet the following requirements.

- [Visual Studio IDE](https://visualstudio.microsoft.com/downloads/) for Windows
- *[Copilot Extension for Visual Studio IDE](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot). 

[See this documentation on how to install Copilot extension for Visual Studio IDE](../CopilotExtensionVS)

*Note: Starting with Visual Studio 17.10, GitHub Copilot is included in Visual Studio IDE. You can enable it by going to **Tools** > **Options** > **GitHub Copilot**.

## Steps

Please follow this step-by-step guide to get started with Copilot in Visual Studio IDE.

### Step 1: Launch Visual Studio IDE

Make sure that you followed all prerequisites and installed Visual Studio IDE and Copilot extension for Visual Studio IDE.

Search for **Visual Studio** after clicking Windows button.

![Search Visual Studio IDE](./images/0_SearchVS.jpg)

Then, your Visual Studio IDE will be launching.

![Launch Visual Studio IDE](./images/1_VSLaunching.jpg)

### Step 2: Create a new project

Once Visual Studio IDE is launched, you will see the following screen. Although you can use an existig project, let's try to create a new project by selecting **Create a new project**.

![Create a new project](./images/2_CreateProject.jpg)

Then, you will see different options. Select **Console App (.NET Framework)** and click **Next**.

![Select Console App (.NET Framework)](./images/3_ConsoleApp.jpg)

Then, you will see the following screen. Enter **HelloCopilot** as the project name and click **Create**.

![Enter project name](./images/4_ProjectName.jpg)

You will see a progress bar while Visual Studio IDE is creating a new project.

![Creating a new project](./images/5_CreateProject.jpg)

### Step 3: Check Copilot is enabled

Let's make sure that Copilot is enabled. On bottom, you should see **Auth Status: OK** under **Output** window. Make sure to select **GitHub Copilot** from the dropdown.

![Check Copilot is enabled](./images/6_VSCodeStatus.jpg)

And you should also see a Copilot icon above the **Output** window.

![Copilot icon](./images/7_CopilotLogo.jpg)

### Step 4: Create a new class named `RockPaperScissors`

Creating a new class named `RockPaperScissors.cs` by right clicking on the project:

![open a new class named](images/RPS_010.png)

### Step 5: Add in comments

Add in comments to describe what the class does. This will create context copilot will use to generate code suggestions. The comments should look like this:

```c#
// create a rock paper scissors game
// 1. ask user to input rock paper or scissors
// 2. have the computer select a random choice
// 3. compare the two choices and send out the results
// 4. ask the user if they want to play again
```

![add in copilot comments](images/rps_020.png)

### Step 6: Ask user for input

Write out the step 1 comment into the class and press enter. GitHub Copilot should start suggesting code which you can decide to reject or accept. 

![add in copilot comments](images/rps_030.png)

**_Shortcut Tip:_** If GH Copilot has not started suggesting code you can trigger it by pressing:

- `Option (⌥)+ \` for mac
- `Alt + \` for windows
- `Alt + \` for linux

### Step 7: Refine the suggestion

Once you've accepted the suggestion, you might see that it has generated code that contains some errors, as indicated by the red unlerlines. We can use GitHub Copilot to help fix these errors!

![add in copilot comments](images/rps_040.png)










<details>
<summary>Cheatsheet</summary>

##### Possible Suggestion

```java
// 1. ask user to input rock paper or scissors
Scanner userChoice = new Scanner(System.in);
System.out.println("Please enter rock, paper, or scissors: ");
String userChoiceString = userChoice.nextLine();
System.out.println("You chose: " + userChoiceString);
```
</details>

### Step 5: Add in computer input

Add in the step two comment and press enter. More code suggestions should appear. Accept the suggestions by pressing `Tab` or `Enter`. 

**_Shortcut Tip:_** If you don't like the first suggestion GitHub Copilot gives you, you can have it show you the next inline suggestion by pressing:

- `Option (⌥) or Alt+]` for Mac
- `Alt + ]` for Windows
- `Alt + ]` for Linux

![add in computer input](images/computer-input-step-five.png)

<details>
<summary>Cheatsheet</summary>

##### Possible Suggestion

```java
// 2. have the computer select a random choice
int computerChoice = (int) (Math.random() * 3);
String computerChoiceString = "";
if (computerChoice == 0) {
    computerChoiceString = "rock";
} else if (computerChoice == 1) {
    computerChoiceString = "paper";
} else {
    computerChoiceString = "scissors";
}
```
</details>

### Step 6: Add in logic via GitHub Copilot UI multi suggestion pannel

Add in the step three comment and press enter. GitHub Copilot should start suggesting code which you can decide to reject or accept.

![demonstrate multi solution pannel](images/demonstrate-multi-solutions-step-six.png)

<details>
<summary>Cheatsheet</summary>

##### Possible Suggestion

```java
// 3. compare the two choices and send out the results
System.out.println("The computer chose: " + computerChoiceString);

if (userChoiceString.equals(computerChoiceString)) {
    System.out.println("It's a tie!");
} else if (userChoiceString.equals("rock")) {
    if (computerChoiceString.equals("paper")) {
        System.out.println("You lose!");
    } else {
        System.out.println("You win!");
    }
} else if (userChoiceString.equals("paper")) {
    if (computerChoiceString.equals("scissors")) {
        System.out.println("You lose!");
    } else {
        System.out.println("You win!");
    }
} else if (userChoiceString.equals("scissors")) {
    if (computerChoiceString.equals("rock")) {
        System.out.println("You lose!");
    } else {
        System.out.println("You win!");
    }
} else {
    System.out.println("Invalid input!");
}
```
</details>

### Step 6 (part 2): Add in logic via GitHub Copilot Inline suggestions

Another way to look through suggestions is to go to the "GitHub Copilot" tab on the right side of the screen. This will show you all the suggestions GitHub Copilot has for you.

![inline suggestions](images/inline-suggestion-step-six-2.png)

### Step 7: Ask user to play again

Add in the step four comment and press enter. GitHub Copilot will generate code to ask users if they want to play again.

**_Shortcut Tip:_** If you only want to add in part of the suggestion, you can use the following shortcut to accept word by word instead of the full suggestion:

- `Command (⌘) + arrow right` for Mac
- `Ctrl + arrow right` for Windows
- `Ctrl + arrow right` for Linux

![ask user to play again](images/ask-user-play-again-step-seven.png)

<details>
<summary>Cheatsheet</summary>

##### Possible Suggestion

```java
// 4. ask the user if they want to play again
System.out.println("Do you want to play again? (y/n)");
String playAgain = userChoice.nextLine();
if (playAgain.equals("y")) {
    main(null);
} else System.out.println("Thanks for playing!");
```
</details>

### Step 8: Run the game

Run the game by pressing the green play button in the top right corner of the screen. Start playing!

![run the game](images/run-the-game.png)













___

### Step 4: Write a simple code

Let's start writing some simple code first. Inside your **Main** method, create a following comment after `//`

```csharp
// Print out Hello, Copilot 3,000 time with incrementing index
```

![Write a simple code](./images/8_FirstCode.jpg)

As soon as you enter next line, you should see that Copilot is suggesting you to write a code. 

![Copilot suggestion](./images/9_CopilotSuggestion.jpg)

Select the first suggestion by hitting **Tab** button.

![Select Copilot suggestion](./images/10_Complete.jpg)

By the way, since this is a Console App, it will be a good idea to add the following line at the end of your **Main** method.

```csharp
Console.ReadLine();
```

This can helps to keep the console window open after the program is finished.

![Add Console.ReadLine()](./images/11_AddReadline.jpg)

Your file should look like this.

![Final code](./images/12_Readline.jpg)

That is it for writing a very simple code using Copilot. We can run this code by clicking **Start** button on top, but let's actually write a function.

### Step 5: Write a function

We will add a function above the **Main** method. Let's add a following comment as a block comment.

```csharp
/*
 * Function to sum all the numbers in a list of integers
 */
```

![Write a function](./images/13_AddFunction.jpg)

Again, when you enter, it should show you a suggestion. Yours might look different frome mine, though.

![Function suggestion](./images/14_FunctionSuggestion.jpg)

Hit **Tab** button to select the first suggestion. Your code might look like this.

![Function code](./images/15_CompleteCode.jpg)

Let's proceed to add codes to run that within main function. In the Main method, start clicking anywhere and click **Enter** button to see suggestions made by Copilot.

![Main method](./images/16_CreateList.jpg)

You can keep hit **Enter** and **Tab** buttons to take suggestions, but make sure that you can stop once you are happy with the result or fix if needed.

![Print](./images/17_Print.jpg)

### Step 6: Run the code

Now, let's run the code. Click **Start** button on top.

![Run the code](./images/18_Start.jpg)

If there is a drop down, click **Start** again.

![Run the code](./images/19_Start.jpg)

Then, you will a console window with the following output.

![Run the code](./images/20_ConfirmResult.jpg)

### Step 7: Add more complicated function

Let's add little more complicated function. Add a following comment as a block comment.

```csharp
/*
 * Function to randomly assign 4 digit codes to N x M matrix representing lockers
 */
```

![Add more complicated function](./images/21_AddMatrix.jpg)

Going back to Main function again, start hitting **Enter** and **Tab** buttons to take suggestions.

![Add main](./images/22_AddMain.jpg)

Sometime, you might need to enter more details result to correct.

![image](https://github.com/asd-management/mdgresourceenterappinnovation/assets/117223792/95bd9919-5003-40c9-bffe-77871f3b291f)


Sometimes, you might encounter an error like this.

![Error](./images/24_PossibleError.jpg)

Although you may not get an exactly same result, this example has a problem with index because it was using `i` as an index for both `for` loops. Let's fix that by changing the second `for` loop to use `j` instead of `i`.

![Fix](./images/25_FixError.jpg)

Remember. Copilot is not perfect, and it can make some dumb mistakes. You might need to fix the code to make it work. You are the main pilot, and Copilot is your assistance.

Your final result when you run the code again might look like this.

![image](https://github.com/asd-management/mdgresourceenterappinnovation/assets/117223792/c4554677-0980-4db6-abf0-08862b5abd80)


That is it! Congratulation on finishing your first exercise with Copilot. You can try to write more complicated code and see how Copilot can help you.
