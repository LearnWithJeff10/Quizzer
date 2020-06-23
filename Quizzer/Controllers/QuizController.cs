using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quizzer.Services;

namespace Quizzer.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizzerRepository _quizzerRepository;

        public QuizController(IQuizzerRepository quizzerRepository)
        {
            _quizzerRepository = quizzerRepository;
        }

        public IActionResult Index()
        {
            return View(_quizzerRepository.Questions);
        }
    }
}
