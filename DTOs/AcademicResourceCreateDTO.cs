using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.DTOs
{
    public class AcademicResourceCreateDTO
    {
        public string Title { get; set; } = default!;
        public string FileUrl { get; set; } = default!;
        public StudentClass StudentClass { get; set; } 
        public int StudentClassId { get; set; }
    }
} 