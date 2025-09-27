namespace Secondary_School_Portal.DTOs
{
    public class ParentCreateDTO
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; } = true;
    }
}