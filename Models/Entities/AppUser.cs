using Microsoft.AspNetCore.Identity;
using Secondary_School_Portal.Models.Entities.Enum;
namespace Secondary_School_Portal.Models.Entities
{
    public class AppUser :IdentityUser
    {
        public string? FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public Student? Student { get; set; }
        public Teacher? Teacher { get; set; }
        public Parent? Parent {get; set; }
    } 
} 