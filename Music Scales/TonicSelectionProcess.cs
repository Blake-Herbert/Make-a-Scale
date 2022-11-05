using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Scales
{
    internal class TonicSelectionProcess
    {
        public int SelectTonic()
        {
            Console.WriteLine("Select first note of the scale:");

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
                default:
                    Console.WriteLine("Invalid tonic");
                    break;
            }
            Console.WriteLine("__________________________________");
            return selectedTonic;
        }

    }
}
