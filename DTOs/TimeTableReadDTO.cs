using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.DTOs
{
    public class TimeTableReadDTO
    {
            public int Id { get; set; }
            public string ClassName { get; set; } = string.Empty;
            public DayOfWeek Day { get; set; }
            public string StartTime { get; set; } = string.Empty;
            public string EndTime { get; set; } = string.Empty;
            public int Session { get; set; }
            public Term Term { get; set; }
    }
}

