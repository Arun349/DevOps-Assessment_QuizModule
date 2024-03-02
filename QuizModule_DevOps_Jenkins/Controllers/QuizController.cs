using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizModule_DevOps_Jenkins.Models;

namespace QuizModule_DevOps_Jenkins.Controllers
{
    [Route("Online quiz/api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
         private static List<QuizModel> quizes = new List<QuizModel>{ };

        [HttpGet]
        public IEnumerable<QuizModel> GetQuizes()
        {
            return quizes;
        }

        [HttpPost]
        public IActionResult PostQuizes(QuizModel quiz)
        {
            quizes.Add(quiz);
            return Ok(quiz);
        }       
    }
}
