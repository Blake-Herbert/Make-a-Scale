string[] allDiatonicNotes = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B "};

int[] majorScaleIntervals = { 2, 2, 1, 2, 2, 2, 1 };
int[] minorScaleIntervals = { 2, 1, 2, 2, 1, 2, 2 };

int selectedKey = 0;

Console.WriteLine("Major or Minor?");
string selectedMode = Console.ReadLine();

switch(selectedMode)
{
    case "Major":

        Console.WriteLine("Major");

        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[0];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[1];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[2];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[3];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[4];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += majorScaleIntervals[5];
        Console.Write(allDiatonicNotes[selectedKey]);
        selectedKey = majorScaleIntervals[0];
        Console.Write(allDiatonicNotes[selectedKey]);
        break;
    case "Minor":
        Console.WriteLine("Minor");
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[0];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[1];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[2];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[3];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[4];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey += minorScaleIntervals[5];
        Console.Write(allDiatonicNotes[selectedKey]);
            selectedKey = minorScaleIntervals[0];
        Console.Write(allDiatonicNotes[selectedKey]);
        break ;
}

