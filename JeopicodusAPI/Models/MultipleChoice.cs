namespace JeopicodusAPI.Models
{
    public class MultipleChoice
    {
    public int MultipleChoiceId { get; set; }
    public string Category { get; set; }
    public string Difficulty { get; set; }
    public string Prompt { get; set; }
    public string Answer { get; set; }
    public string Wrong1 { get; set; }
    public string Wrong2 { get; set; }
    public string Wrong3 { get; set; }
    }
}