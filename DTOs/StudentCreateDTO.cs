using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class StudentCreateDTO
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public StudentClass StudentClass { get; set; }
        public int StudentClassId { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public string RegNumber { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
