using Secondary_School_Portal.Models.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Secondary_School_Portal.DTOs
{
    public class AppUserCreateDTO
    {
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(8)]
        public string? Password { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}
