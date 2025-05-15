namespace RepoQcu.Models
{
    public class Faq
    {
        private int id;

        public int Id { get => id; set => id = value; }
        public required string Question { get; set; }
        public required string Answer { get; set; }
    }
}
