namespace Secondary_School_Portal.DTOs
{
    public class ParentReadDTO
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<string> ChildrenNames { get; set; } = new List<string>();
    }
}
