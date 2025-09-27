namespace Secondary_School_Portal.Models.Entities
{
    public class Notification
    {
       
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; } = default!;
        
    }
}