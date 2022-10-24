string[] allDiatonicNotes = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B ", 
                              "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };

Console.WriteLine("Select a key");
int selectedKey = 0;

switch (Console.ReadLine().ToLower())
{
    case "c":
        selectedKey = 0;
        break;
    case "c#":
        selectedKey = 1;
        break;
    case "db":
        selectedKey = 1;
        break;
    case "d":
        selectedKey = 2;
        break;
    case "d#":
        selectedKey = 3;
        break;
    case "eb":
        selectedKey = 3;
        break;
    case "e":
        selectedKey = 4;
        break;
    case "f":
        selectedKey = 5;
        break;
    case "f#":
        selectedKey = 6;
        break;
    case "gb":
        selectedKey = 6;
        break;
    case "g":
        selectedKey = 7;
        break;
    case "g#":
        selectedKey = 8;
        break;
    case "ab":
        selectedKey = 8;
        break;
    case "a":
        selectedKey = 9;
        break;
    case "a#":
        selectedKey = 10;
        break;
    case "bb":
        selectedKey = 10;
        break;
    case "b":
        selectedKey = 11;
        break;
}

Console.WriteLine("Major or Minor?");
switch (Console.ReadLine().ToLower())
{
    case "major":
        Console.WriteLine("C Major Scale: ");

        int[] majorScaleIntervals = { 0, 2, 4, 5, 7, 9, 11, 12 };
        foreach (int interval in majorScaleIntervals)
        {
            Console.Write(allDiatonicNotes[selectedKey + interval]);
        }
        break;

    case "minor":
        Console.Write("C Minor Scale: ");

        int[] minorScaleIntervals = { 0, 2, 3, 5, 7, 8, 10, 12 };
        foreach (int interval in minorScaleIntervals)
        {
            Console.Write(allDiatonicNotes[selectedKey + interval]);
        }

        break;
        default:
        Console.Write("Ooops");
        break;
}