namespace Jeopicodus.Models
{
    public class MultipleChoice : Question
    {
        public string Prompt { get; set; }
        public string Answer { get; set; }
        public string Wrong1 { get; set; }
        public string Wrong2 { get; set; }
        public string Wrong3 { get; set; }
        
        public MultipleChoice()
        {
            this.Type = "MultipleChoice";
        }
    }
}