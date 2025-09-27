namespace Secondary_School_Portal.DTOs
{
    public class AssignmentUpdateDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string? FileUrl { get; set; }
    }
}
