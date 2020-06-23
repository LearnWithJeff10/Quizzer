using System.Collections.Generic;

namespace Quizzer.Models
{
    public class Question
    {
        public string QuestionText { get; set; }

        public List<string> Choices { get; set; } = new List<string>();

        public string StudentAnswer { get; set; }

        public string CorrectAnswer { get; set; }
    }
}
