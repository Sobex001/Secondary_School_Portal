using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.DTOs
{
    public class StudentUpdateDTO
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
