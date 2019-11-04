namespace JeopicodusAPI.Models
{
    public class FillInTheBlank
    {
        public int FillInTheBlankId { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }
    }
}