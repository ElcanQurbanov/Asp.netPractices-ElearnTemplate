namespace ElearnFrontToBack.Models
{
    public class News: BaseEntity
    {
        public DateTime PublisherDate { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Image { get; set; }
    }
}
