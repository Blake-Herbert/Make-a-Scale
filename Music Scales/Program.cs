using Music_Scales;

TonicSelectionProcess Tonic = new TonicSelectionProcess();
int selectedTonic = Tonic.SelectTonic();


Console.WriteLine("Major or Minor scale?");


switch (Console.ReadLine().ToLower())
{
    case "major":       
        Scales.MajorScale(selectedTonic);
        break;

    case "minor":
        Scales.MinorScale(selectedTonic);
        break;
    default:
        Console.WriteLine("Mode not recognized");
        break;
}

Console.WriteLine();
Console.WriteLine("__________________________________");