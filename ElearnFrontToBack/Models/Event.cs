namespace ElearnFrontToBack.Models
{
    public class Event:BaseEntity
    {
        public string? Title { get; set; }
        public DateTime PublisherDate { get; set; }
        public string? Description { get; set; }
    }
}
