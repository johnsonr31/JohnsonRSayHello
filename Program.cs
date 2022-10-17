// Richard Johnson
// 10-17-2022
// Say Hello
//

// This bool is declared to decide if the game loops
bool playAgain = true;

// This while statement will loop the game as long as playAgain is true
Console.Clear();
while(playAgain == true)
{
    // These will print text to the console to address the player
    Console.WriteLine("\"Oh, hello there! What is your name?\"");
    Console.Write("Type your name, or type \"END\" to exit: ");

    // This will take the user's input, and save it as a string. The line beneath that one will take the user's input and set it to be uppercase
    string userInput = Console.ReadLine();
    userInput = userInput.ToUpper();
    if (userInput == "END")
    {
        Console.WriteLine("Alright, goodbye.");
        playAgain = false;
    }
    else
    {
        Console.WriteLine($"\"Good evening, {userInput}. I hope you're having a good day today!\"");
        Console.WriteLine("");
    }
}