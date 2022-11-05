using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Music_Scales
{
    internal static class Scales
    {
        private static string[] allDiatonicNotes = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B ",
                                                     "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };


        public static void MajorScale(int selectedTonic)
        {
            
            Console.WriteLine("Major Scale in the key of " + allDiatonicNotes[selectedTonic] + ": ");

            int[] majorScaleIntervals = { 0, 2, 4, 5, 7, 9, 11, 12 };
            foreach (int interval in majorScaleIntervals)
            {
                Console.Write(allDiatonicNotes[selectedTonic + interval]);
            }
        }
        

        public static void MinorScale(int selectedTonic)
        {
            
            Console.WriteLine("Minor Scale in the key of " + allDiatonicNotes[selectedTonic] + ": ");

            int[] minorScaleIntervals = { 0, 2, 3, 5, 7, 8, 10, 12 };
            foreach (int interval in minorScaleIntervals)
            {
                Console.Write(allDiatonicNotes[selectedTonic + interval]);
            }
        }
    }
}
