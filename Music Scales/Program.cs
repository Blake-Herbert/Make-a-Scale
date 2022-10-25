string[] allDiatonicNotes = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B ", 
                              "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };

Console.WriteLine("Select scale's tonic:");
int selectedTonic = 0;

switch (Console.ReadLine().ToLower())
{
    case "c":
        selectedTonic = 0;
        break;
    case "c#":
    case "db":
        selectedTonic = 1;
        break;
    case "d":
        selectedTonic = 2;
        break;
    case "d#":
    case "eb":
        selectedTonic = 3;
        break;
    case "e":
        selectedTonic = 4;
        break;
    case "f":
        selectedTonic = 5;
        break;
    case "f#":
    case "gb":
        selectedTonic = 6;
        break;
    case "g":
        selectedTonic = 7;
        break;
    case "g#":
    case "ab":
        selectedTonic = 8;
        break;
    case "a":
        selectedTonic = 9;
        break;
    case "a#":
    case "bb":
        selectedTonic = 10;
        break;
    case "b":
        selectedTonic = 11;
        break;
}

Console.WriteLine("Major or Minor scale?");
switch (Console.ReadLine().ToLower())
{
    case "major":
        Console.WriteLine( allDiatonicNotes[selectedTonic] + "Major Scale: ");

        int[] majorScaleIntervals = { 0, 2, 4, 5, 7, 9, 11, 12 };
        foreach (int interval in majorScaleIntervals)
        {
            Console.Write(allDiatonicNotes[selectedTonic + interval]);
        }
        break;

    case "minor":
        Console.Write(allDiatonicNotes[selectedTonic] + "Minor Scale: ");
        int[] minorScaleIntervals = { 0, 2, 3, 5, 7, 8, 10, 12 };
        foreach (int interval in minorScaleIntervals)
        {
            Console.Write(allDiatonicNotes[selectedTonic + interval]);
        }

        break;
        default:
        Console.Write("Invalid mode selection");
        break;
}
Console.WriteLine();
Console.WriteLine("______________________________________");