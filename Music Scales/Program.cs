using System.Reflection;
using Music_Scales;
using static System.Console;


MainMenu();

void MainMenu()
{
    string mainMenuPrompt = @"Welcome to MAKE-A-SCALE
------------------------";
    string[] mainMenuOptions = { "Get a scale", "Make a scale", "About", "Exit" };
    Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
    mainMenu.DisplayOptions();
    int selectedMainMenuOption = mainMenu.Run();

    switch (selectedMainMenuOption)
    {
        case 0:
            GetAScale();
            break;
        case 1:
            Clear();
            WriteLine("Still working on that!");
            ReadKey();
            MainMenu();
            break;
        case 2:
            Clear();
            WriteLine("I am Blake and I made this");
            ReadKey();
            MainMenu();
            break;
        case 3:
            Clear();
            WriteLine("Press any key to exit");
            ReadKey(true);
            Environment.Exit(0);
            break;
        default:
            break;
    }
}





void GetAScale()
{
    int TonicMenu()
    {
        string tonicMenuPrompt = "Select the starting note for your scale";
        string[] tonicMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };
        Menu tonicMenu = new Menu(tonicMenuPrompt, tonicMenuOptions);
        tonicMenu.DisplayOptions();
        int selectedTonic = tonicMenu.Run();

        return selectedTonic;

    }

    int selectedTonic = TonicMenu();

    ModeMenu();


    void ModeMenu()
    {
        string modeSelectionPrompt = "Which mode would you like?";
        string[] modeSelectionOptions = { "Major", "Minor" };
        Menu modesMenu = new Menu(modeSelectionPrompt, modeSelectionOptions);
        modesMenu.DisplayOptions();
        int selectedMode = modesMenu.Run();

        switch (selectedMode)
        {
            case 0:
                Scales.MajorScale(selectedTonic);
                ReadKey(true);
                break;
            case 1:
                Scales.MinorScale(selectedTonic);
                ReadKey(true);
                break;
            default:
                Console.WriteLine("Try again");
                break;
        }
        MainMenu();
    }
}

Console.WriteLine();
Console.WriteLine("__________________________________");