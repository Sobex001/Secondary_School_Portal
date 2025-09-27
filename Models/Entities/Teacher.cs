using Secondary_School_Portal.Models.Entities;

public class Teacher
{
    public string? Id { get; set; }
    public string AppUserId { get; set; } = default!;
    public AppUser AppUser { get; set; } = default!;
    public string? Address { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    public ICollection<TimeTable> TimeTables { get; set; } = new List<TimeTable>();
    public ICollection<Result> Results { get; set; } = new List<Result>();
}
