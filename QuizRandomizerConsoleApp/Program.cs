var exitProgram = false;

Console.Clear();
Messages.DisplayMessage(Messages.welcomeMessage);
Messages.PressAnyKeyToContinue();

while (!exitProgram)
{
    var menuInput = Menu.DisplayMenu();

    exitProgram = Menu.ProcessMenuSelection(menuInput);
}

Console.WriteLine(Messages.goodbyMessage);

