using Quizzer.Models;
using System.Collections.Generic;

namespace Quizzer.Services
{
    public class QuizzerRepository
    {
        public List<Question> Questions{ get; set; }


        public QuizzerRepository()
        {
            Questions = LoadQuiz();
        }

        public List<Question> LoadQuiz()
        {
            List<Question> quiz = new List<Question>
            {
                new Question
                {
                    QuestionText = "What does CSS stand for?",
                    Choices = new List<string>
                    {
                        "Cascading Style Sheets",
                        "Computer Style Sheets",
                        "Creative Style Sheets",
                        "Colorful Style Sheets"
                    }
                },
                new Question
                {
                    QuestionText = "How do you make a list that lists its items with squares?",
                    Choices = new List<string>
                    {
                        "list-style-type: square;",
                        "list-type: square;",
                        "list: square;",
                        "None of the above"
                    }
                },
                new Question
                {
                    QuestionText = "How do you display hyperlinks without an underline?",
                    Choices = new List<string>
                    {
                        "a {text-decoration:none;}",
                        "a {decoration:no-underline;}",
                        "a {text-decoration:no-underline;}",
                        "a {underline:none;}"
                    }
                }
            };

            return quiz;
        }
    }
}
