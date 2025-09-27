using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Models.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public string? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public double ExamScore { get; set; }
        public double CAScore { get; set; }
        public Term Term { get; set; }
        public string Session { get; set; }
    }
}
