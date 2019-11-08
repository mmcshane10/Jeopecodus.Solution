namespace Jeopicodus.Models
{
    public abstract class Question{
        public int Id { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }
    }
}