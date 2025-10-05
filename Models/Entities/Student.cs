
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public AppUser? AppUser { get; set; }
        public string? AppUserId {get; set; }
        public int StudentClassId { get; set; }
        public StudentClass StudentClass { get; set; } = default!;
        public DateTime DateOfBirth { get; set; } 
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string? RegNumber { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }  
        public ICollection<Result>? Results { get; set; }
        public ICollection<ReportCard>? ReportCards { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public Parent? Parent { get; set; }
        public int? ParentId { get; set; }
    }
}
