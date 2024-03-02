namespace QuizModule_DevOps_Jenkins.Models
{
    public class QuizModel
    {
        public int Quiz_Id { get; set; }
        public string? Quiz_title { get; set; }
        public string? Category { get; set; }
        public int No_of_questions { get; set; }
        public int Max_marks { get; set; }
        public string? Total_time { get; set; }

    }
}
