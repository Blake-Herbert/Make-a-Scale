using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
    public static class Scales
    {
        private static string[] allDiatonicNotes = { "C", "C#/Db", "D", "Eb/D#", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "Bb/A#", "B",
                                                     "C", "C#/Db", "D", "Eb/D#", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "Bb/A#", "B" };


        
        
        public static void IonianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine(allDiatonicNotes[selectedStartingNote] + " Major / Ionian Scale:");

            int[] ionianScaleIntervals = { 0, 2, 4, 5, 7, 9, 11, 12 };
            foreach (int interval in ionianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



        public static void DorianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine(allDiatonicNotes[selectedStartingNote] + " Dorian Scale:");

            int[] dorianScaleIntervals = { 0, 2, 3, 5, 7, 9, 10, 12 };
            foreach (int interval in dorianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }




        public static void PhrygianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine( allDiatonicNotes[selectedStartingNote] + " Phrygian Scale:");

            int[] phrygianScaleIntervals = { 0, 1, 3, 5, 7, 8, 10, 12 };
            foreach (int interval in phrygianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



        public static void LydianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine( allDiatonicNotes[selectedStartingNote] + " Lydian Scale:");

            int[] lydianScaleIntervals = { 0, 2, 4, 6, 7, 9, 11, 12 };
            foreach (int interval in lydianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



        public static void MixolydianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine(allDiatonicNotes[selectedStartingNote] + " Mixolydian Scale:");

            int[] mixolydianScaleIntervals = { 0, 2, 4, 5, 7, 9, 10, 12 };
            foreach (int interval in mixolydianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



        public static void AeolianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine( allDiatonicNotes[selectedStartingNote] + " Minor / Aeolian Scale:");

            int[] minorScaleIntervals = { 0, 2, 3, 5, 7, 8, 10, 12 };
            foreach (int interval in minorScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



        public static void LocrianScale(int selectedStartingNote)
        {
            Clear();
            WriteLine(allDiatonicNotes[selectedStartingNote] + " Locrian Scale:");

            int[] locrianScaleIntervals = { 0, 1, 3, 5, 6, 8, 10, 12 };
            foreach (int interval in locrianScaleIntervals)
            {
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
        }



    }
}
