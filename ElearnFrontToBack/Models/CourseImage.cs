namespace ElearnFrontToBack.Models
{
    public class CourseImage:BaseEntity
    {
        public string? Image { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
