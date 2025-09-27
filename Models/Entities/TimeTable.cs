using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Models.Entities
{
    public class TimeTable
    {
        public int Id { get; set; }            
        public int StudentClassId { get; set; }
        public StudentClass StudentClass { get; set; } = default!;
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Session { get; set; }
        public Term Term { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = default!;
        public string? TeacherId { get; set; } 
        public Teacher Teacher { get; set; } = default!; 
    }
}