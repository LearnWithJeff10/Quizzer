using Quizzer.Models;
using System.Collections.Generic;

namespace Quizzer.Services
{
    public interface IQuizzerRepository
    {
        List<Question> Questions { get; set; }
    }
}