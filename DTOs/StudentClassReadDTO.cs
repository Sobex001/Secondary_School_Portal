namespace Secondary_School_Portal.DTOs
{
    public class StudentClassReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StudentsCount { get; set; }
        public int SubjectsCount { get; set; }
    }
}
