public class TeacherUpdateDTO
{
    public string Address { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public List<int> SubjectIds { get; set; } = new();
}

