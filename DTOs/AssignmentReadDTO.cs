namespace Secondary_School_Portal.DTOs
{
    public class AssignmentReadDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? TeacherName { get; set; }
        public string? StudentClass { get; set; }
        public DateTime DueDate { get; set; }
        public string? FileUrl { get; set; }
    }
}
