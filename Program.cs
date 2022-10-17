// Richard Johnson
// 10-17-2022
// Say Hello
//

bool playAgain = true;

while(playAgain == true)
{
    Console.WriteLine("\"Oh, hello there! What is your name?\"");
    Console.Write("Type your name, or type \"END\" to exit:");
    string userInput = Console.ReadLine();
    userInput = userInput.ToUpper();
}