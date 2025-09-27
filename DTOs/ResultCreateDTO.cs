using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class ResultCreateDTO
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public string? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public Term Term { get; set; }
        public string? Session { get; set; }
        public double CAScore { get; set; } = 0;
        public double ExamScore { get; set; } = 0;
    }
}
