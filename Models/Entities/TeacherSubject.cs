using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Models.Entities
{
    public class TeacherSubject
    {
        public string? TeacherId { get; set; }
        public int SubjectId { get; set; }
        public Teacher Teacher { get; set; } = default!;
        public Subject Subject { get; set; } = default!;
        public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UnassignedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsPrimary { get; set; } = false;
        public int SessionYear { get; set; } = DateTime.Now.Year;
        public Term Term { get; set; }

        public string? AssignedBy { get; set; }  
        public string? Notes { get; set; }      
    }
}

