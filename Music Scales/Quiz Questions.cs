using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
    public class QuizQuestions
    {
        int firstQuestion()
        {
            string firstQuestionPrompt = @"Which scale is this?"
            string[] firstQuestionOptions = { "Ionion", "Lydian", "Mixolydian" };
            Menu firstQuestion = new Menu(firstQuestionPrompt, firstQuestionOptions);
            firstQuestion.DisplayOptions();

            return firstQuestion.Run();

        }

    }
}
