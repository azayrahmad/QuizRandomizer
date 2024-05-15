class Messages
{
    // List of message strings
    public static readonly string welcomeMessage = @"Welcome to MathQuiz.
Test your basic math skills in this exciting game!";
    public static readonly string menuMessage = "What would you like to do? Type the associated number and press Enter!";
    public static readonly string unavailableMenuOption = "Apologies, but the menu you are selecting is not available. Please choose another option!";
    public static readonly string quitQuery = "Do you really want to quit? (y/n)";
    public static readonly string goodbyMessage = "Good bye!";
    public static readonly string pressAnyKeyToContinue = "Press any key to continue...";

    public static void DisplayMessage(string message){
        Console.WriteLine(message);
    }

    public static void PressAnyKeyToContinue(){
        Console.WriteLine(pressAnyKeyToContinue);
        Console.ReadKey();
    }
}