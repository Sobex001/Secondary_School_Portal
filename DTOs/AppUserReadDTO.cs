using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class AppUserReadDTO
    {
        public string Id { get; set; }
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public Role Role { get; set; } = default!;
        public string? ProfilePicture { get; set; }
    }
}
