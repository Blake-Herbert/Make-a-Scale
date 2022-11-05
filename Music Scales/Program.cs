using System.Reflection;
using Music_Scales;


int TonicMenu()
{
    string mainMenuPrompt = "Select the starting note for your scale";
    string[] mainMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };
    Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
    mainMenu.DisplayOptions();
    int selectedIndex = mainMenu.Run();

    return selectedIndex;
    
}

int selectedTonic = TonicMenu();

ModeMenu();

void ModeMenu()
{
    string modeSelectionPrompt = "Which mode would you like?";
    string[] modeSelectionOptions = { "Major", "Minor" };
    Menu modesMenu = new Menu(modeSelectionPrompt, modeSelectionOptions);
    modesMenu.DisplayOptions();
    int selectMode = modesMenu.Run();

    switch (selectMode)
    {
        case 0:
            Scales.MajorScale(selectedTonic);
            break;
        case 1:
            Scales.MinorScale(selectedTonic);
            break;
        default:
            Console.WriteLine("Try again");
            break;
    }
}

Console.WriteLine();
Console.WriteLine("__________________________________");