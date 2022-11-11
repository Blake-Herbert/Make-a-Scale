﻿using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Music_Scales;
using static System.Console;



MainMenu();



void MainMenu()
{
    Title = "Scale Practice Companion";
    string mainMenuPrompt = @"Welcome to the Scale Practice Companion
Use Arrow Keys to cycle through menus!
------------------------";
    string[] mainMenuOptions = { "Timed Exercise", "Show Me the Scales", "Exit" };

    Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
    mainMenu.DisplayOptions();
    int selectedMainMenuOption = mainMenu.Run();

    switch (selectedMainMenuOption)
    {
        case 0:
            TimedChallenge();
            break;
        case 1:
            ShowMeScales();
            break;
        case 2:
            Clear();
            WriteLine("Press any key to exit");
            ReadKey();
            Environment.Exit(0);
            break;
        default:
            break;
    }
}






void TimedChallenge()
{
    Clear();
    string Prompt = @"This timed challenge will test your knowledge of scales and transposition.
Are you ready to start?
----------------------------------";
    string[] Options = { "Begin", "Return to main menu" };


    Menu startChallengeMenu = new Menu(Prompt, Options);
    startChallengeMenu.DisplayOptions();

    if (startChallengeMenu.Run() == 1)
        MainMenu();
    else
        Clear();
    WriteLine("Still working on it...");
    


    ReadKey();
    MainMenu();
}





void ShowMeScales()
{
    Scales.ScaleConstructor(ModeMenu(), StartingNoteMenu());
    MainMenu();


    int ModeMenu()
    {
        string modeSelectionPrompt = @"Which mode would you like?
----------------------------------";
        string[] modeSelectionOptions = { "Ionian/Major", "Dorian", "Phrygian", "Lydian", "Mixolydian", "Aeolian/Minor", "Locrian" };


        Menu modesMenu = new Menu(modeSelectionPrompt, modeSelectionOptions);
        modesMenu.DisplayOptions();
        int selectedMode = modesMenu.Run();

        return selectedMode;
    }

    int StartingNoteMenu()
    {
        string startingNotePrompt = @"Select the starting note for your scale
----------------------------------";
        string[] startingNoteMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };


        Menu startingNoteMenu = new Menu(startingNotePrompt, startingNoteMenuOptions);
        startingNoteMenu.DisplayOptions();
        int selectedStartingNote = startingNoteMenu.Run();

        return selectedStartingNote;
    }
}

    

    


    


    
 