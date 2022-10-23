string[] allDiatonicNotes = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B ", "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };

Console.WriteLine("Major or Minor?");
int selectedKey = 0;
string selectedMode = Console.ReadLine().ToLower();

switch (selectedMode)
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
}