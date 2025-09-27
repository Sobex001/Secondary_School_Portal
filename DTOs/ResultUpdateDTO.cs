using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class ResultUpdateDTO
    {
        public string Subject { get; set; } = string.Empty;
        public Term Term { get; set; }
        public string Session { get; set; } = "2025/2026";
        public double CAScore { get; set; } = 0;
        public double ExamScore { get; set; } = 0;
    }
}
