using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
    public class QuizQuestion
    {
        public int firstQuestion()
        {
            int correctAnswers = 0;
            int incorrectAnswers = 0;
            
            string firstQuestionPrompt = "@\"Which Mode is this scale?" +
                "(C) (D) (E) (F) (G) (A) (B) (C)";
            string[] firstQuestionOptions = { "Ionian", "Lydian", "Mixolydian", "Dorian" };
            Menu firstQuestion = new Menu(firstQuestionPrompt, firstQuestionOptions);
            firstQuestion.DisplayOptions();
            int firstAnswer = firstQuestion.Run();

            if (firstAnswer == 0)
                correctAnswers++;
            else
                incorrectAnswers++;
            return correctAnswers; 

        }

    }
}
