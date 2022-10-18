string[] allDiatonicNotes = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B" };

int[] majorScaleIntervals = { 2, 2, 1, 2, 2, 2, 1 };

int selectedKey = 0;
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[0];
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[1];
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[2];
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[3];
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[4];
Console.WriteLine(allDiatonicNotes[selectedKey]);
selectedKey += majorScaleIntervals[5];
Console.WriteLine(allDiatonicNotes[selectedKey]);