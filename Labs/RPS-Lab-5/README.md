# Lab 5: Unit Testing - Rock / Paper / Visual Studio

Welcome to GitHub Copilot Labs! In this example, we'll add some unit tests to our project.

## Prerequisites

Make sure that you have completed the [Lab 4](../RPS-Lab-4/README.md)

## Steps

Please follow this step-by-step guide to start adding functionality to your program.

---

### Step 1: Adding Unit Tests

Up until now, we've behaved like normal developers - we created a working program, then make it look pretty, then reluctantly added some documentation.  Now, we're going to do something that most developers tend to put off - we're going to add some unit tests!

First, let's add a new project to our solution.  Right-click on the solution and select "Add" -> "New Project...", using the MS Test project template and giving it a name of RockPaperScissors.Tests.

![Testing 1](images/RPS_500.png)

Once you have a project, it should open the default UnitTest1.cs file.  Add a simple Console.WriteLine("Hello World!"); statement to the file to test it out and make sure you can run the unit tests.  Once you've validated that, you can delete the default test method and we'll start building out some real tests.  You will have to build your project before you can open the Test Explorer window and run the tests. Once you get it to run, you should see all green check marks in the Test Explorer window.

![Testing 2](images/RPS_505.png)

---

### Step 2: Create some tests

TBD!

---

### Lab Complete: Your code is now testable!

Congratulations on finishing your fifth exercise with Copilot!  Your program should now be ready for you to create more unit tests to ensure complete coverage. In the next lab (if it ever gets written...!), we'll use Copilot to create a pipeline that builds your program, runs the unit tests, and then shows your code coverage in the pipeline output.
