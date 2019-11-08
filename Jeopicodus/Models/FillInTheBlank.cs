namespace Jeopicodus.Models
{
    public class FillInTheBlank : Question
    {
        public string Prompt { get; set; }
        public string Answer { get; set; }

        public FillInTheBlank()
        {
            this.Type = "FillInTheBlank";
        }
    }
}