# Lab 3: Adding Beauty (optional) - Rock / Paper / Visual Studio

Welcome to GitHub Copilot Labs! In this example, we'll make our program we created in Lab 2 a little more interesting.

## Prerequisites

Make sure that you have completed the [Lab 2](../RPS-Lab-2/README.md)

## Steps

Please follow this step-by-step guide to start adding functionality to your program.

---

### Step 1: Create a method to display ASCII art

Let's go back and use the comment method of prompting Copilot to create a method to display ASCII art for the Rock, Paper, and Scissors.  This will make our game a little more interesting. Add this comment in your code and hit enter.

``` c#
// create a method that will display ascii art of a rock, paper, or scissors
```

![ASCII Art 1](images/RPS_300.png)

You may get ones that don't *look* right because they are all one one line.  You can ask Copilot to reformat the ASCII art by breaking it up into multiple lines.  Give it a couple of tries to see if you can get it to format correctly:

``` c#
can you break down this code so that each line of ascii art is written on it's own line with it's own console.writeline?
```

You can coax it along by asking it to refine the code:

``` c#
that's almost right, but the rock is still on only two lines. can you break that up to have six lines like the others?
```

Once you're done, it should look something like this

![ASCII Art 1](images/RPS_320.png)

---

### Step 2: Get your program to display the choices in ASCII art

TBD! (This is a placeholder for future content)

---

Press F5 to run and test out your new game!

---

### Lab Complete: Input is Validated!

Congratulations on finishing your second exercise with Copilot!  Your program should now be a bit more robust and accept only valid input from the user. In the next lab, we'll work on making the user interface a bit nicer.
