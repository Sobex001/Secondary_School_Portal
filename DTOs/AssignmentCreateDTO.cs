using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.DTOs
{
    public class AssignmentCreateDTO
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Teacher Teacher { get; set; }
        public string TeacherFullName { get; set; } = default!;
        public StudentClass StudentClass { get; set; }
        public int StudentClassId { get; set; } = default!;
        public DateTime DueDate { get; set; }
        public string FileUrl { get; set; } = default!;
    }
}
