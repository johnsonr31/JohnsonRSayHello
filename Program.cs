// Richard Johnson
// 10-17-2022
// Say Hello
//

// This bool is declared to decide if the game loops
bool playAgain = true;
bool endingLoop = true;

// This while statement will loop the game as long as playAgain is true
Console.Clear();
while(playAgain == true)
{
    // These will print text to the console to address the player
    Console.WriteLine("\"Oh, hello there! What is your name?\"");
    Console.Write("Type your name, or type \"END\" to end it: ");

    // This will take the user's input, and save it as a string. The line beneath that one will take the user's input and set it to be uppercase
    string userInput = Console.ReadLine();
    userInput = userInput.ToUpper();
    if (userInput == "END")
    {
        // This will run if the player types "END"
        Console.WriteLine("Alright, goodbye.");
        // playAgain is now set to false, ending the game
        playAgain = false;
    }
    else
    {
        // This will run if the player types anything aside from "NO"
        Console.WriteLine($"\"Good evening, {userInput}. I hope you're having a good day today!\"");
        // The player will be asked if they'd like to play again, and their input will be recieved and set to uppercase
        Console.Write("Want to play again? YES or NO: ");
        endingLoop = true;
        
    while(endingLoop == true)
    {
        string yesNo = Console.ReadLine();
        yesNo = yesNo.ToUpper();

            if(yesNo == "NO")
        {
            // If the player types NO, playAgain is false
            Console.WriteLine($"Goodbye, {userInput}...");
            playAgain = false;
            endingLoop = false;
        }
        else if(yesNo == "YES")
        {
            // If the player types YES, playAgain is still true, and the loop continues
            Console.WriteLine("Alright!");
            endingLoop = false;
        }
        else
        {
            Console.WriteLine("Invalid input");
            Console.Write("Please type YES or NO: ");
        }
    }
        
        
        
        
    }
}
    
    