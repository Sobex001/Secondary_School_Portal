using Secondary_School_Portal.Models.Entities.Enum;

public class TimeTableCreateDTO
{
    public int StudentClassId { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int Session { get; set; }
    public Term Term { get; set; }
    public int SubjectId { get; set; }
    public string? TeacherId { get; set; }
}

