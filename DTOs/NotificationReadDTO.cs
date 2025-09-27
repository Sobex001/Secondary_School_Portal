namespace Secondary_School_Portal.DTOs
{
    public class NotificationReadDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? RecipientEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
    }
}
