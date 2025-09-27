using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class ResultReadDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public Teacher? Teacher { get; set; }
        public string TeacherId { get; set; }
        public double CAScore { get; set; } = 0;
        public double ExamScore { get; set; } = 0;
        public Term Term { get; set; }
        public string Session { get; set; } = "2025/2026";
        public double Total { get; set; }
        public string? Grade { get; set; }
        public string? Remark { get; set; }
    }
}
