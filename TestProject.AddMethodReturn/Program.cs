// ShouldPlay: This method should retrieve user input and determine if the user wants to play again
// WinOrLose: This method should determine if the player has won or lost

// target: The random target number between 1 and 5
// roll: The result of a random six-sided die roll

using System.Runtime.CompilerServices;

Random random = new Random();


Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6); // Generates number between 1 and 5
        var roll = random.Next(1, 7); // Generates number between 1 and 6

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target)); // passing both parameters
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

// check user input 
// if yes continue
// if no stop 
bool ShouldPlay()
{
    string? input = Console.ReadLine();
    return input?.ToUpper() == "Y";  // Safe way to handle possible null input
}

// compare roll with target 
// return true if players win (roll > target)
// return false if players loss (roll < and = target)
string WinOrLose(int roll, int target) // add parameters to WinOrLose() so it can acccss target and roll values 
{
    if (roll > target)
    {
        return "You Win!";
    } 
    else
    {
        return "You Lose!";
    }
}