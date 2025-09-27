using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class StudentReadDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ParentName { get; set; } = string.Empty;
        public string StudentClassName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; } = string.Empty;
        public string RegNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
