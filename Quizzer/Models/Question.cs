using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzer.Models
{
    public class Question
    {
        public string QuestionText { get; set; }

        public List<string> Choices { get; set; } = new List<string>();

        [Display(Name = "Answer")]
        public string StudentAnswer { get; set; }

        public string CorrectAnswer { get; set; }
    }
}
