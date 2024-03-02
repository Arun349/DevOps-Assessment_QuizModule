using Microsoft.AspNetCore.Http.HttpResults;
using QuizModule_DevOps_Jenkins.Controllers;
using QuizModule_DevOps_Jenkins.Models;

namespace QuizModule_Jenkins_TestProject
{
    public class Tests
    {
        private QuizController controller;
        [SetUp]
        public void Setup()
        {
            controller = new QuizController();
        }

        [Test]
        public void TestMethodForGetQuizes()
        {
            IEnumerable<QuizModel> result = controller.GetQuizes();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostQuiz()
        {
            var newItem = new QuizModel
            {
                Quiz_Id = 1,
                Quiz_title = "test",
                Category = "test",
                No_of_questions = 50,
                Max_marks=10,
                Total_time="test"
            };
            var actionResult = controller.PostQuizes(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostQuizNull()
        {
            var newItem = new QuizModel
            {
               Quiz_Id = 1,
                Quiz_title = null,
                Category = null,
                No_of_questions = 50,
                Max_marks=10,
                Total_time=null
            };
            var actionResult = controller.PostQuizes(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}