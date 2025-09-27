namespace Secondary_School_Portal.Models.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public string? CreatedById { get; set; }
        public AppUser? CreatedBy { get; set; }
    }
}
