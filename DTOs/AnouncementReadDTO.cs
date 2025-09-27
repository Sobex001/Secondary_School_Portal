namespace Secondary_School_Portal.DTOs
{
    public class AnnouncementReadDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Message { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
    }
}