class Menu
{
    /// <summary>
    /// List of selectable menu. Add more strings for new option.
    /// </summary>
    public static string[] MenuStrings = {
    "Play the game",
    "Exit program"
    };

    /// <summary>
    /// Clear the screen and display the list of available menu dynamically.
    /// </summary>
    /// <returns>Integer of selected option (starts from 1)</returns>
    public static int DisplayMenu()
    {
        int selectedOption = 0;
        ConsoleKeyInfo enteredKey;

        Menu.WriteMenuList(selectedOption);

        do
        {
            enteredKey = Console.ReadKey();

            if (enteredKey.Key == ConsoleKey.UpArrow && selectedOption > 0)
            {
                selectedOption--;
                Menu.WriteMenuList(selectedOption);
            }
            if (enteredKey.Key == ConsoleKey.DownArrow && selectedOption < MenuStrings.Length - 1)
            {
                selectedOption++;
                Menu.WriteMenuList(selectedOption);
            }
            if (enteredKey.Key == ConsoleKey.Enter)
            {
                return selectedOption + 1;
            }

        } while (true);
    }

    /// <summary>
    /// Processes the user's menu selection and executes the corresponding action.
    /// After adding new menu string, call the corresponding action here.
    /// </summary>
    /// <param name="menuInput">Option selected by user (starts from 1)</param>
    /// <returns>True if user wants to exit the program</returns>
    public static bool ProcessMenuSelection(int menuInput)
    {
        var exitProgram = false;

        switch (menuInput)
        {
            case 1:
                MathQuiz.PlayTheGame();
                break;
            case 2:
                exitProgram = ExitProgram();
                break;
            default:
                Console.WriteLine(Messages.unavailableMenuOption);
                break;
        }

        return exitProgram;
    }

    /// <summary>
    /// Display menu list with selected index
    /// </summary>
    /// <param name="selectedIndex">Selected menu index</param>
    private static void WriteMenuList(int selectedIndex)
    {
        Console.Clear();
        Console.WriteLine(Messages.menuMessage);
        Menu.WriteOptions(MenuStrings, selectedIndex);
    }

    /// <summary>
    /// Display a list of options with selected option marked ">"
    /// </summary>
    /// <param name="options">Array of string of options</param>
    /// <param name="selectedIndex">Index of the selected option</param>
    private static void WriteOptions(string[] options, int selectedIndex)
    {
        for(int i = 0; i < MenuStrings.Length; i++)
        {
            Console.Write(i == selectedIndex ? ">" : " ");
            Console.WriteLine($"{i+1}. {MenuStrings[i]}");
        }
    }

    /// <summary>
    /// Prompt the user to exit the program.
    /// </summary>
    /// <returns>True if user confirm to exit the program.</returns>
    private static bool ExitProgram()
    {
        var exitProgram = false;
        Console.WriteLine(Messages.quitQuery);
        var quitInput = Console.ReadLine()!;

        if (quitInput.Trim().Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            exitProgram = true;
        }

        return exitProgram;
    }
}