// Richard Johnson
// 10-17-2022
// Say Hello
//

// This bool is declared to decide if the game loops
bool playAgain = true;
bool endingLoop = true;
bool isNum;
int num = 0;

// This while loop will continue as long as playAgain is true
Console.Clear();
while(playAgain == true)
{
    // These will print text to the console to address the player
    Console.WriteLine("\"Oh, hello there! What is your name?\"");
    Console.Write("Type your name, or type END to end it: ");

    // This will take the user's input, and save it as a string. The line beneath that one will take the user's input and set it to be uppercase
    string userInput = Console.ReadLine();
    userInput = userInput.ToUpper();
    isNum = Int32.TryParse(userInput, out num);
    if (userInput == "END" && isNum != true)
    {
        // This will run if the player types "END"
        Console.WriteLine("Alright, goodbye.");
        // playAgain is now set to false, ending the game
        playAgain = false;
    }
    else if (isNum != true)
    {
        // This will run if the player types any input aside from END and their input isn't a number
        Console.WriteLine($"\"Good evening, {userInput}. I hope you're having a good day today!\"");
        // The player will be asked if they'd like to play again, and their input will be recieved and set to uppercase
        Console.Write("Want to play again? YES or NO: ");
        endingLoop = true;
        
    // This is a second while loop that will loop if the player doesn't write YES or NO.
    while(endingLoop == true)
    {
        // This will take the user's input, and save it to a string. It will also set it to uppercase
        string yesNo = Console.ReadLine();
        yesNo = yesNo.ToUpper();

            if(yesNo == "NO")
        {
            // If the player types NO, playAgain is false
            Console.WriteLine($"Then goodbye, {userInput}.");
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
            // If the player types anything aside from YES or NO, this will be printed to the console,
            // and they will be asked to type YES or NO again
            Console.WriteLine("Invalid input");
            Console.Write("Please type YES or NO: ");
        }
    }
        
        
        
        
    }
    else if(isNum == true)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Names aren't numbers");
        Console.WriteLine("Please enter a name");
        Console.WriteLine(" ");
    }
}
    
    